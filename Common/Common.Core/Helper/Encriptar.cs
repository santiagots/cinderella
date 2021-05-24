﻿using System;
using System.Security.Cryptography;

namespace Common.Core.Helper
{ 
    public class Encriptar
    {
        private static string m_strPassPhrase = "MyPriv@Password!$$";    // ---- any text string is good here
        private static string m_strHashAlgorithm = "MD5";                // --- we are doing MD5 encryption - can be "SHA1"
        private static int m_strPasswordIterations = 2;              // --- can be any number
        private static string m_strInitVector = "@1B2c3D4e5F6g7H8";      // --- must be 16 bytes
        private static int m_intKeySize = 256;                       // --- can be 192 or 128

        public static string EncriptarMD5(string plainText)
        {
            string strReturn = string.Empty;
            string p_strSaltValue = "P@SSW@RD@09";
            // Convert strings into byte arrays.
            // Let us assume that strings only contain ASCII codes.
            // If strings include Unicode characters, use Unicode, UTF7, or UTF8 
            // encoding.

            try
            {
                byte[] initVectorBytes;
                initVectorBytes = System.Text.Encoding.ASCII.GetBytes(m_strInitVector);

                byte[] saltValueBytes;
                saltValueBytes = System.Text.Encoding.ASCII.GetBytes(p_strSaltValue);

                // Convert our plaintext into a byte array.
                // Let us assume that plaintext contains UTF8-encoded characters.
                byte[] plainTextBytes;
                plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);

                // First, we must create a password, from which the key will be derived.
                // This password will be generated from the specified passphrase and 
                // salt value. The password will be created using the specified hash 
                // algorithm. Password creation can be done in several iterations.

                Rfc2898DeriveBytes password;

                password = new Rfc2898DeriveBytes(m_strPassPhrase, saltValueBytes, m_strPasswordIterations);

                // Use the password to generate pseudo-random bytes for the encryption
                // key. Specify the size of the key in bytes (instead of bits).
                byte[] keyBytes;
                int intKeySize = 0;

                intKeySize = System.Convert.ToInt32((m_intKeySize / (double)8));

                keyBytes = password.GetBytes(intKeySize);

                // Create uninitialized Rijndael encryption object.
                System.Security.Cryptography.RijndaelManaged symmetricKey;
                symmetricKey = new System.Security.Cryptography.RijndaelManaged();

                // It is reasonable to set encryption mode to Cipher Block Chaining
                // (CBC). Use default options for other symmetric key parameters.
                symmetricKey.Mode = System.Security.Cryptography.CipherMode.CBC;

                // symmetricKey.Padding = PaddingMode.Zeros


                // Generate encryptor from the existing key bytes and initialization 
                // vector. Key size will be defined based on the number of the key 
                // bytes.
                System.Security.Cryptography.ICryptoTransform encryptor;
                encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);

                // Define memory stream which will be used to hold encrypted data.
                System.IO.MemoryStream memoryStream;
                memoryStream = new System.IO.MemoryStream();

                // Define cryptographic stream (always use Write mode for encryption).
                System.Security.Cryptography.CryptoStream cryptoStream;
                cryptoStream = new System.Security.Cryptography.CryptoStream(memoryStream, encryptor, System.Security.Cryptography.CryptoStreamMode.Write);
                // Start encrypting.
                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);

                // Finish encrypting.
                cryptoStream.FlushFinalBlock();

                // Convert our encrypted data from a memory stream into a byte array.
                byte[] cipherTextBytes;
                cipherTextBytes = memoryStream.ToArray();

                // Close both streams.
                memoryStream.Close();
                cryptoStream.Close();

                // Convert encrypted data into a base64-encoded string.
                string cipherText;
                cipherText = Convert.ToBase64String(cipherTextBytes);

                // Return encrypted string.
                strReturn = cipherText;
            }
            catch (Exception ex)
            {
                strReturn = null;
            }

            return strReturn;
        }

        public static string DesencriptarMD5(string cipherText)
        {
            string strReturn = string.Empty;
            string p_strSaltValue = "P@SSW@RD@09";
            // Convert strings defining encryption key characteristics into byte
            // arrays. Let us assume that strings only contain ASCII codes.
            // If strings include Unicode characters, use Unicode, UTF7, or UTF8
            // encoding.

            try
            {
                byte[] initVectorBytes;
                initVectorBytes = System.Text.Encoding.ASCII.GetBytes(m_strInitVector);

                byte[] saltValueBytes;
                saltValueBytes = System.Text.Encoding.ASCII.GetBytes(p_strSaltValue);

                // Convert our ciphertext into a byte array.
                byte[] cipherTextBytes;
                cipherTextBytes = Convert.FromBase64String(cipherText);

                // First, we must create a password, from which the key will be 
                // derived. This password will be generated from the specified 
                // passphrase and salt value. The password will be created using
                // the specified hash algorithm. Password creation can be done in
                // several iterations.

                Rfc2898DeriveBytes password;

                password = new Rfc2898DeriveBytes(m_strPassPhrase, saltValueBytes, m_strPasswordIterations);

                // Use the password to generate pseudo-random bytes for the encryption
                // key. Specify the size of the key in bytes (instead of bits).
                byte[] keyBytes;
                int intKeySize;

                intKeySize = System.Convert.ToInt32((m_intKeySize / (double)8));

                keyBytes = password.GetBytes(intKeySize);

                // Create uninitialized Rijndael encryption object.
                System.Security.Cryptography.RijndaelManaged symmetricKey;
                symmetricKey = new System.Security.Cryptography.RijndaelManaged();

                // It is reasonable to set encryption mode to Cipher Block Chaining
                // (CBC). Use default options for other symmetric key parameters.
                symmetricKey.Mode = System.Security.Cryptography.CipherMode.CBC;

                // symmetricKey.Padding = PaddingMode.Zeros

                // Generate decryptor from the existing key bytes and initialization 
                // vector. Key size will be defined based on the number of the key 
                // bytes.
                System.Security.Cryptography.ICryptoTransform decryptor;
                decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);

                // Define memory stream which will be used to hold encrypted data.
                System.IO.MemoryStream memoryStream;
                memoryStream = new System.IO.MemoryStream(cipherTextBytes);

                // Define memory stream which will be used to hold encrypted data.
                System.Security.Cryptography.CryptoStream cryptoStream;
                cryptoStream = new System.Security.Cryptography.CryptoStream(memoryStream, decryptor, System.Security.Cryptography.CryptoStreamMode.Read);

                // Since at this point we don't know what the size of decrypted data
                // will be, allocate the buffer long enough to hold ciphertext;
                // plaintext is never longer than ciphertext.
                byte[] plainTextBytes;
                plainTextBytes = new byte[cipherTextBytes.Length + 1];

                // Start decrypting.
                int decryptedByteCount;
                decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);

                // Close both streams.
                memoryStream.Close();
                cryptoStream.Close();

                // Convert decrypted data into a string. 
                // Let us assume that the original plaintext string was UTF8-encoded.
                string plainText;
                plainText = System.Text.Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);

                // Return decrypted string.
                strReturn = plainText;
            }
            catch (Exception ex)
            {
                strReturn = null;
            }

            return strReturn;
        }
    }
}