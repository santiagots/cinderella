using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Pkcs;

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
            if (!string.IsNullOrWhiteSpace(passwordCertificado))
            {
                objCert.Import(File.ReadAllBytes(pathCertificado), passwordCertificado, X509KeyStorageFlags.PersistKeySet);
            }
            else
            {
                objCert.Import(File.ReadAllBytes(pathCertificado));
            }
            return objCert;
        }
    }
}
