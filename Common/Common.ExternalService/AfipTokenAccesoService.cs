using Common.Core.Helper;
using Common.ExternalService.Contracts;
using System;
using System.Text;
using System.Xml;

namespace Common.ExternalService
{
    public class AfipTokenAccesoService
    {
        private static string XmlLoginTicketRequestTemplate = "<loginTicketRequest><header><uniqueId></uniqueId><generationTime></generationTime><expirationTime></expirationTime></header><service></service></loginTicketRequest>";
        private static AfipTokenAcceso AfipTokenAcceso = new Contracts.AfipTokenAcceso();

        public static AfipTokenAcceso Obtener(string nombreServicio, string pathCertificado, string passwordCertificado = "")
        {
            if (AfipTokenAcceso.FechaExpiracion < DateTime.Now)
            {
                XmlDocument logInTicket = ObtenerLogInTicket(nombreServicio);

                // Convierto el Login Ticket Request a bytes, firmo el msg y lo convierto a Base64
                Encoding EncodedMsg = Encoding.UTF8;
                byte[] logInTicketByte = EncodedMsg.GetBytes(logInTicket.OuterXml);
                byte[] logInTicketFirmadoByte = CertificadosX509.FirmaMensaje(logInTicketByte, pathCertificado, passwordCertificado);
                string logInTicketFirmadoBase64 = Convert.ToBase64String(logInTicketFirmadoByte);

                XmlDocument logInTicketRespuesta = ObtenerLogInTicketRespuesta(logInTicketFirmadoBase64);

                AfipTokenAcceso = new AfipTokenAcceso(
                                                    uint.Parse(logInTicketRespuesta.SelectSingleNode("//uniqueId").InnerText),
                                                    DateTime.Parse(logInTicketRespuesta.SelectSingleNode("//generationTime").InnerText),
                                                    DateTime.Parse(logInTicketRespuesta.SelectSingleNode("//expirationTime").InnerText),
                                                    logInTicketRespuesta.SelectSingleNode("//sign").InnerText,
                                                    logInTicketRespuesta.SelectSingleNode("//token").InnerText);
            }
            return AfipTokenAcceso;
        }

        private static XmlDocument ObtenerLogInTicket(string nombreServicio)
        {
            XmlDocument xmlLoginTicketRequest = new XmlDocument();
            xmlLoginTicketRequest.LoadXml(XmlLoginTicketRequestTemplate);

            XmlNode xmlNodoUniqueId = xmlLoginTicketRequest.SelectSingleNode("//uniqueId");
            XmlNode xmlNodoGenerationTime = xmlLoginTicketRequest.SelectSingleNode("//generationTime");
            XmlNode xmlNodoExpirationTime = xmlLoginTicketRequest.SelectSingleNode("//expirationTime");
            XmlNode xmlNodoService = xmlLoginTicketRequest.SelectSingleNode("//service");
            xmlNodoGenerationTime.InnerText = DateTime.Now.ToString("s");
            xmlNodoExpirationTime.InnerText = DateTime.Now.AddMinutes(+10).ToString("s");
            xmlNodoUniqueId.InnerText = DateTime.Now.ToString("MMddhhmmss");
            xmlNodoService.InnerText = nombreServicio;

            return xmlLoginTicketRequest;
        }

        private static XmlDocument ObtenerLogInTicketRespuesta(string logInTicketFirmado)
        {
            Afip.Wsaa.LoginCMSClient loginCMSClient = new Afip.Wsaa.LoginCMSClient();
            string loginTicketResponse = loginCMSClient.loginCms(logInTicketFirmado);

            XmlDocument XmlLoginTicketResponse = new XmlDocument();
            XmlLoginTicketResponse.LoadXml(loginTicketResponse);
            return XmlLoginTicketResponse;
        }
    }
}
