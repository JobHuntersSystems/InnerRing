using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SpaceShip_RSACryptoManager
{
    static class ShipCryptoManager
    {
        static public string EncryptWithPublicKey(string plainText, string publicKeyXml)
        {
            if (string.IsNullOrEmpty(plainText)) throw new ArgumentException("El texto no puede estar vacío.");
            if (string.IsNullOrEmpty(publicKeyXml)) throw new ArgumentException("La clave pública no puede estar vacía.");

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(publicKeyXml);

                byte[] dataToEncrypt = Encoding.UTF8.GetBytes(plainText);
                byte[] encryptedBytes = rsa.Encrypt(dataToEncrypt, false);

                return Convert.ToBase64String(encryptedBytes);
            }
        }
    }
}
