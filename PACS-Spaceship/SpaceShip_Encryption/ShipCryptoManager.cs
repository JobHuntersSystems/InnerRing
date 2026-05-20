using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip_Encryption
{
    public class ShipCryptoManager
    {
        static public string EncryptWithPublicKey(string plainText, string publicKeyXml)
        {
           
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
