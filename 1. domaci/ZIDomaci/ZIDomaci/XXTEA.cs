using System;
using System.Collections.Generic;
using System.Text;


namespace ZIDomaci
{
    public class XXTEA
    {
        public uint K1 { get; set; }
        public uint K2 { get; set; }
        public uint K3 { get; set; }
        public uint K4 { get; set; }
        public ushort N { get; set; }
        public uint DELTA { get; set; }

        public string InitializationVector { get; set; }
        public XXTEA()
        {
            K1 = 0;
            K2 = 0;
            K3 = 0;
            K4 = 0;
            N = 0;
            InitializationVector = "";
            DELTA = 0x9e3779b9;
        }
        public XXTEA(uint k1, uint k2, uint k3, uint k4, ushort n)
        {
            LoadKeys(k1, k2, k3, k4);
            N = n;
            InitializationVector = "";
            DELTA = 0x9e3779b9;
        }
        public void EncodeBlock(ref uint[] vector)
        {
            uint y=0, z=0, sum=0;
            ushort p=0, rounds, e=0;
            uint[] key = { K1, K2, K3, K4 };
            Func<uint> MX = () => (((z >> 5 ^ y << 2) + (y >> 3 ^ z << 4)) ^ ((sum ^ y) + (key[(p & 3) ^ e] ^ z)));
            if (vector.Length > 1)
            { 
                rounds = (ushort)(6 + 52 / vector.Length);
                sum = 0;
                z = vector[vector.Length - 1];
                do
                {
                    sum += DELTA;
                    e = (ushort)((sum >> 2) & 3);
                    for (p = 0; p < vector.Length - 1; p++)
                    {
                        y = vector[p + 1];
                        z = vector[p] += MX();
                    }

                    y = vector[0];
                    z = vector[vector.Length - 1] += MX();
                } while ((--rounds) > 0);
            }
        }

        public void DecodeBlock(ref uint[] vector)
        {
            uint y=0, z=0, sum=0;
            ushort p=0, rounds, e=0;
            uint[] key = { K1, K2, K3, K4 };

            rounds = (ushort)(6 + 52 / vector.Length);
            sum = rounds * DELTA;
            y = vector[0];
            Func<uint> MX = () => (((z >> 5 ^ y << 2) + (y >> 3 ^ z << 4)) ^ ((sum ^ y) + (key[(p & 3) ^ e] ^ z)));
            do
            {
                e = (ushort)((sum >> 2) & 3);
                for (p = (ushort)(vector.Length - 1); p > 0; p--)
                {
                    z = vector[p - 1];
                    y = vector[p] -= MX();
                }
                z = vector[vector.Length - 1];
                y = vector[0] -= MX();
                sum -= DELTA;
            } while ((--rounds) > 0);
        }

        public bool IsInitialized()
        {
            return K1 != 0 && K2 != 0 && K3 != 0 && K4 != 0 && N != 0 && InitializationVector!="";
        }

        public void LoadKeys(uint k1, uint k2, uint k3, uint k4)
        {
            K1 = k1;
            K2 = k2;
            K3 = k3;
            K4 = k4;
        }

        public void LoadBlockSize(ushort n)
        {
            N = n;
            //InitializationVector = new string(new char[n]);
        }
    }
}
