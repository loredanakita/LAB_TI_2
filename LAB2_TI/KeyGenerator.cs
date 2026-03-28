using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace LAB2_TI
{
    internal class KeyGenerator
    {
        public const int REGISTER_LENGTH = 39;
        public const int BYTE_LENGTH = 8;
        private BitArray inputData;
        private BitArray outputData;
        private BitArray keyStream;
        private BitArray shiftRegister;
        public byte[] encryptedData;

        public KeyGenerator(BitArray inputData, string seed)
        {
            this.inputData = inputData;
            this.shiftRegister = LoadRegister(seed);
            this.keyStream = GenerateKeyStream();
        }

        public static int GetRegLength() { return REGISTER_LENGTH; }

        private BitArray LoadRegister(string seedBits)
        {
            shiftRegister = new BitArray(REGISTER_LENGTH);
            for (int i = 0; i < seedBits.Length; i++)
                shiftRegister[i] = seedBits[i] == '1';
            return shiftRegister;
        }

        private BitArray ShiftRegister(BitArray reg)
        {
            bool tap1 = reg[0];
            bool tap2 = reg[reg.Length - 3 - 1];
            for (int i = 0; i < reg.Length; i++)
            {
                if (i == reg.Length - 1)
                    reg[reg.Length - 1] = tap1 ^ tap2;
                else
                    reg[i] = reg[i + 1];
            }
            return reg;
        }

        private BitArray GenerateKeyStream()
        {
            BitArray stream = new BitArray(inputData.Length);
            for (int i = 0; i < stream.Length; i++)
            {
                stream[i] = shiftRegister[0];
                shiftRegister = ShiftRegister(shiftRegister);
            }
            return stream;
        }

        private BitArray ApplyXor()
        {
            BitArray xorResult = new BitArray(inputData.Length);
            for (int i = 0; i < inputData.Length; i++)
                xorResult[i] = inputData[i] ^ keyStream[i];
            return xorResult;
        }

        public byte[] GetCipherText()
        {
            outputData = ApplyXor();
            int totalBytes = (outputData.Length + 7) / 8;
            byte[] cipherBytes = new byte[totalBytes];

            for (int i = 0; i < outputData.Length; i++)
            {
                if (outputData[i])
                {
                    int bytePos = i / 8;
                    int bitPos = i % 8;

                    cipherBytes[bytePos] |= (byte)(1 << (7 - bitPos));
                }
            }
            encryptedData = cipherBytes;
            return cipherBytes;
        }

        public string GetKey(bool showAll)
        {
            int space = 1;
            string keyOutput = "";
            if (keyStream.Length >= 140 && !showAll)
            {
                for (int i = 0; i < 70; i++)
                {
                    if (keyStream[i])
                        keyOutput += "1";
                    else
                        keyOutput += "0";
                    if (space  == 8)
                    {
                        space = 0;
                        keyOutput += " ";
                    } 
                        
                    space++;
                };
                keyOutput += "\r\n...\r\n";
                space = 1;
                for (int i = keyStream.Length - 70; i < keyStream.Length; i++)
                {
                    if (keyStream[i])
                        keyOutput += "1";
                    else
                        keyOutput += "0";
                    if (space == 8)
                    {
                        space = 0;
                        keyOutput += " ";
                    }

                    space++;
                }
            }
            else
              for (int i = 0; i < keyStream.Length; i++)
              {
                 if (keyStream[i])
                    keyOutput += "1";
                 else
                    keyOutput += "0";

                 if(space == 8)
                 {
                    space = 0;
                    keyOutput += " ";
                 }

                 space++;
              }
            return keyOutput;
        }
    }
}
