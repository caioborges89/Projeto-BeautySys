using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace BeautySys.Util
{
    class Criptografia
    {
        public static string criptografar(string texto)
        {
            string chave = @"pigbtxis";
            byte[] bytTexto;
            byte[] bytChave;
            byte[] bytIV = new byte[] {122, 10, 30, 20, 15, 39, 21, 43, 53, 69, 48, 58,
                                       60, 71, 98, 12, 33, 11, 192, 232, 77, 80, 99, 108,
                                       210, 28, 34, 24, 222, 134, 202, 94};
            int intCaracter;
            int intREstante;
            CryptoStream objcrypto;
            MemoryStream objmemory = new MemoryStream();
            RijndaelManaged objrijndael = new RijndaelManaged();

            bytTexto = Encoding.Default.GetBytes(texto);

            intCaracter = chave.Length;

            if (intCaracter >= 16)
            {

                chave = chave.Substring(0, 16);
            }
            else
            {
                intCaracter = chave.Length;
                intREstante = 16 - intCaracter;
                chave = chave + StrDup(intREstante, "X");
            }

            bytChave = Encoding.Default.GetBytes(chave.ToCharArray());

            objrijndael.BlockSize = 256;
            objrijndael.FeedbackSize = 256;


            objcrypto = new CryptoStream(objmemory,
                objrijndael.CreateEncryptor(bytChave, bytIV), CryptoStreamMode.Write);

            objcrypto.Write(bytTexto, 0, bytTexto.Length);

            objcrypto.FlushFinalBlock();

            byte[] bytCodificado = objmemory.ToArray();
            objmemory.Close();
            objcrypto.Close();

            string cripto = Convert.ToBase64String(bytCodificado);

            return cripto;
        }

        private static string StrDup(int qtd, string texto)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < qtd; i++)
            {
                sb.Append(texto);
            }
            return sb.ToString();
        }

        public static string descriptografar(string texto)
        {
            string chave = "pigbtxis";
            byte[] bytTexto;
            byte[] bytChave;
            byte[] bytTemp;
            byte[] bytIV = new byte[] {122, 10, 30, 20, 15, 39, 21, 43, 53, 69, 48, 58,
                                       60, 71, 98, 12, 33, 11, 192, 232, 77, 80, 99, 108,
                                       210, 28, 34, 24, 222, 134, 202, 94};
            int intCaracter;
            int intRestante;
            string RetornaTexto = string.Empty;
            CryptoStream objcrypto;
            MemoryStream objmemory = new MemoryStream();
            RijndaelManaged objrijndael = new RijndaelManaged();

            bytTexto = Convert.FromBase64String(texto);

            intCaracter = chave.Length;

            if (intCaracter >= 16)
            {
                chave = chave.Substring(0, 16);
            }
            else
            {
                intCaracter = chave.Length;
                intRestante = 16 - intCaracter;
                chave = chave + StrDup(intRestante, "X");
            }

            bytChave = Encoding.Default.GetBytes(chave.ToCharArray());

            objrijndael = new RijndaelManaged();
            objrijndael.BlockSize = 256;
            objrijndael.FeedbackSize = 256;

            objmemory = new MemoryStream(bytTexto);

            bytTemp = new byte[texto.Length];

            try
            {
                objcrypto = new CryptoStream(objmemory,
                    objrijndael.CreateDecryptor(bytChave, bytIV), CryptoStreamMode.Read);

                objcrypto.Read(bytTemp, 0, bytTemp.Length);

                //objcrypto.FlushFinalBlock();
                objmemory.Close();
                objcrypto.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            RetornaTexto = Encoding.Default.GetString(bytTemp);
            RetornaTexto = RetornaTexto.Trim('\0');
            return RetornaTexto;

        }
    }
}
