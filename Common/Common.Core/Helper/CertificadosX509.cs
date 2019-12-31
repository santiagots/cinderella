using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core.Helper
{
    public class CertificadosX509
    {
        public static byte[] FirmaMensaje(byte[] mensaje, string pathCertificado, string passwordCertificado = "")
        {
            return FirmaMensaje(mensaje, ObtieneCertificadoDesdeArchivo(pathCertificado, passwordCertificado));
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
