﻿using Common.Core.Exceptions;
using Common.Core.Helper;
using Factura.Core.Model.AfipAgreggate;
using System;
using System.Text;
using System.Xml;

namespace Factura.ExternalService
{
    public class AfipTokenAccesService
    {
        private static string XmlLoginTicketRequestTemplate = "<loginTicketRequest><header><uniqueId></uniqueId><generationTime></generationTime><expirationTime></expirationTime></header><service></service></loginTicketRequest>";
        private static AfipTokenAcces AfipTokenAccesoCache;

        public static AfipTokenAcces Obtener(string nombreServicio, string pathCertificado, string passwordCertificado = "")
        {
            if (AfipTokenAccesoCache == null || !AfipTokenAccesoCache.EsValido())
            {
                AfipTokenAccesoCache = ObtenerLogInTicket(nombreServicio, pathCertificado, passwordCertificado);
            }
            return AfipTokenAccesoCache;
        }

        public static AfipTokenAcces ObtenerLogInTicket(string nombreServicio, string pathCertificado, string passwordCertificado = "")
        {
            XmlDocument logInTicket = ObtenerLogInTicket(nombreServicio);

            // Convierto el Login Ticket Request a bytes, firmo el msg y lo convierto a Base64
            Encoding EncodedMsg = Encoding.UTF8;
            byte[] logInTicketByte = EncodedMsg.GetBytes(logInTicket.OuterXml);
            byte[] logInTicketFirmadoByte = CertificadosX509.FirmaMensaje(logInTicketByte, pathCertificado, passwordCertificado);
            string logInTicketFirmadoBase64 = Convert.ToBase64String(logInTicketFirmadoByte);

            XmlDocument logInTicketRespuesta = ObtenerLogInTicketRespuesta(logInTicketFirmadoBase64);

            return new AfipTokenAcces(
                    long.Parse(logInTicketRespuesta.SelectSingleNode("//uniqueId").InnerText),
                    DateTime.Parse(logInTicketRespuesta.SelectSingleNode("//generationTime").InnerText),
                    DateTime.Parse(logInTicketRespuesta.SelectSingleNode("//expirationTime").InnerText),
                    logInTicketRespuesta.SelectSingleNode("//sign").InnerText,
                    logInTicketRespuesta.SelectSingleNode("//token").InnerText
                );
        }

        private static XmlDocument ObtenerLogInTicket(string nombreServicio)
        {
            XmlDocument xmlLoginTicketRequest = new XmlDocument();
            xmlLoginTicketRequest.LoadXml(XmlLoginTicketRequestTemplate);

            XmlNode xmlNodoUniqueId = xmlLoginTicketRequest.SelectSingleNode("//uniqueId");
            XmlNode xmlNodoGenerationTime = xmlLoginTicketRequest.SelectSingleNode("//generationTime");
            XmlNode xmlNodoExpirationTime = xmlLoginTicketRequest.SelectSingleNode("//expirationTime");
            XmlNode xmlNodoService = xmlLoginTicketRequest.SelectSingleNode("//service");
            DateTime fecha = DateTime.Now;
            xmlNodoGenerationTime.InnerText = fecha.AddSeconds(-10).ToString("s");
            xmlNodoExpirationTime.InnerText = fecha.AddMinutes(+10).ToString("s");
            xmlNodoUniqueId.InnerText = fecha.ToString("MMddhhmmss");
            xmlNodoService.InnerText = nombreServicio;

            return xmlLoginTicketRequest;
        }

        private static XmlDocument ObtenerLogInTicketRespuesta(string logInTicketFirmado)
        {
            try
            {
                Afip.Wsaa.LoginCMSClient loginCMSClient = new Afip.Wsaa.LoginCMSClient();
                string loginTicketResponse = loginCMSClient.loginCms(logInTicketFirmado);

                XmlDocument XmlLoginTicketResponse = new XmlDocument();
                XmlLoginTicketResponse.LoadXml(loginTicketResponse);
                return XmlLoginTicketResponse;
            }
            catch(Exception ex)
            {
                throw new NegocioException($"Error al obtener el token de acceso ante la AFIP.", ex);
            }
        }
    }
}
