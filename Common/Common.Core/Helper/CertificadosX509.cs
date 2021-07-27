using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Pkcs;
using Common.Core.Exceptions;

namespace Common.Core.Helper
{
    public class CertificadosX509
    {
        public static byte[] FirmaMensaje(byte[] mensaje, string pathCertificado, string passwordCertificado = "")
        {
            return FirmaMensaje(mensaje, ObtieneCertificadoDesdeArchivo(pathCertificado, passwordCertificado));
        }

        public static DateTime ObtenerVencimiento(string pathCertificado, string passwordCertificado = "")
        {
            X509Certificate2 certificado = ObtieneCertificadoDesdeArchivo(pathCertificado, passwordCertificado);
            return certificado.NotAfter;
        }

        public static string ObtenerCN(string pathCertificado, string passwordCertificado = "")
        {
            X509Certificate2 certificado = ObtieneCertificadoDesdeArchivo(pathCertificado, passwordCertificado);
            return certificado.Subject;
        }

        private static byte[] FirmaMensaje(byte[] mensaje, X509Certificate2 certificado)
        {
            // Pongo el mensaje en un objeto ContentInfo (requerido para construir el obj SignedCms)
            ContentInfo infoContenido = new ContentInfo(mensaje);
            SignedCms cmsFirmado = new SignedCms(infoContenido);

            // Creo objeto CmsSigner que tiene las caracteristicas del firmante
            CmsSigner cmsFirmante = new CmsSigner(certificado)
            {
                IncludeOption = X509IncludeOption.EndCertOnly
            };

            // Firmo el mensaje PKCS #7
            cmsFirmado.ComputeSignature(cmsFirmante);

            // Encodeo el mensaje PKCS #7.
            return cmsFirmado.Encode();
        }

        private static X509Certificate2 ObtieneCertificadoDesdeArchivo(string pathCertificado, string passwordCertificado)
        {

            X509Certificate2 objCert = new X509Certificate2();
            try
            {
                if (!string.IsNullOrWhiteSpace(passwordCertificado))
                {
                    objCert.Import(File.ReadAllBytes(pathCertificado), passwordCertificado, X509KeyStorageFlags.PersistKeySet);
                }
                else
                {
                    objCert.Import(File.ReadAllBytes(pathCertificado));
                }
            }
            catch
            {
                throw new NegocioException("Se ha producido un error al obtener los datos del certificado. Por favor, verifique que el mismo este correcto o que se encuentre la clave provada del mismo. En caso de que el error persista genere un nuevo certificado en la AFIP.");
            }
            return objCert;
        }
    }
}
