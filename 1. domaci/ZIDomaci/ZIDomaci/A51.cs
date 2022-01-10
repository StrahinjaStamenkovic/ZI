using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace ZIDomaci
{
    public class A51
    {
        public byte[] X { get; set; }
        public byte[] Y { get; set; }
        public byte[] Z { get; set; }

        public ulong Seed { get; set; }
        public uint XSeed { get; set; }
        public uint YSeed { get; set; }
        public uint ZSeed { get; set; }


        public byte XVoteBit { get; set; }
        public byte YVoteBit { get; set; }
        public byte ZVoteBit { get; set; }

        public byte[] XStepBits { get; set; }
        public byte[] YStepBits { get; set; }
        public byte[] ZStepBits { get; set; }


        public ushort Keystream { get; set; }

        public ushort InitializationVector { get; set; }
        public A51()
        {
            X = new byte[19];
            Y = new byte[22];
            Z = new byte[23];

            Keystream = 0;
            InitializationVector = 0;

        }
        public A51(byte xvb, byte yvb, byte zvb, byte[] xsb, byte[] ysb, byte[] zsb)
        {
            X = new byte[19];
            Y = new byte[22];
            Z = new byte[23];

            Keystream = 0;
            InitializationVector = 0;

            LoadVoteBits(xvb, yvb, zvb);
            LoadStepBits(xsb, ysb, zsb);

        }

        public bool LoadSeed(ulong seed)
        {
            Seed = seed;
            XSeed = (uint)(seed & ((ulong)Math.Pow(2, 19) - 1));
            seed >>= 19;
            YSeed = (uint)(seed & ((ulong)Math.Pow(2, 22) - 1));
            seed >>= 22;
            ZSeed = (uint)(seed & ((ulong)Math.Pow(2, 23) - 1));

            X = FromUIntToByteArrayOfBits(X, XSeed);
            Y = FromUIntToByteArrayOfBits(Y, YSeed);
            Z = FromUIntToByteArrayOfBits(Z, ZSeed);

            return true;
        }
        public bool LoadRegisterSeeds(ulong xSeed, ulong ySeed, ulong zSeed)
        {
            Seed = (xSeed | ((ySeed | (zSeed<<22)) << 19)) ;
            XSeed = (uint)xSeed;
            YSeed = (uint)ySeed;
            ZSeed = (uint)zSeed;

            X = FromUIntToByteArrayOfBits(X, XSeed);
            Y = FromUIntToByteArrayOfBits(Y, YSeed);
            Z = FromUIntToByteArrayOfBits(Z, ZSeed);

            return true;
        }        
        public bool LoadStepBits(byte[] xsb,byte[] ysb, byte[] zsb)
        {
            XStepBits = xsb;
            YStepBits = ysb;
            ZStepBits = zsb;
            return true;
        }
        public bool LoadVoteBits(byte xvb, byte yvb, byte zvb)
        {

            XVoteBit = xvb > 19 ? (byte)19 : xvb;
            YVoteBit = yvb > 22 ? (byte)22 : yvb;
            ZVoteBit = zvb > 23 ? (byte)23 : zvb;

            return true;
        }
        public byte EncodeByte(byte number)
        {
            for (var i = 0; i < 8; i++)
            {
                byte x0 = 0,
                     y0 = 0,
                     z0 = 0;

                foreach (var xStep in XStepBits)
                    x0 ^= X[xStep];

                foreach (var yStep in YStepBits)
                    y0 ^= Y[yStep];

                foreach (var zStep in ZStepBits)
                    z0 ^= Z[zStep];

                x0 ^= 0;    //to remove te initialized value
                y0 ^= 0;
                z0 ^= 0;

                byte majority = 0;  //syntax error if not initialized
                if (X[XVoteBit] == Y[YVoteBit] || X[XVoteBit] == Z[ZVoteBit])
                    majority = X[XVoteBit];
                else if (Y[YVoteBit] == Z[ZVoteBit])
                    majority = Y[YVoteBit];

                if (X[XVoteBit] == majority)
                    X = ShiftRightAndInsert(X, x0);
                if (Y[YVoteBit] == majority)
                    Y = ShiftRightAndInsert(Y, y0);
                if (Z[ZVoteBit] == majority)
                    Z = ShiftRightAndInsert(Z, z0);

                Keystream |= (byte)((X[18] ^ Y[21] ^ Z[22])<<i);
            }
            byte encoded = (byte) (number ^ Keystream);
            Keystream = 0;
            
            return encoded;
        }
        public ushort Encode2Bytes(ushort number)
        {
            byte lower = (byte)(number);
            byte upper = (byte)(number >> 8);

            ushort encoded = (ushort)((ushort)EncodeByte(lower) | (ushort)(EncodeByte(upper) << 8));
            return encoded;
        }
        public static byte ByteArrayOfBitsToByte(byte[] ba)
        {
            byte retVal = 0;
            for (var i = 0; i < 8; i++)
                retVal |= (byte)(ba[i] << i);
            return retVal;
        }
        public static byte[] ShiftRightAndInsert(byte[] array, byte insertValue)
        {
            for (var i = 0; i < array.Length - 1; i++)
                array[i + 1] = array[i];
            array[0] = insertValue;
            return array;
        }
        public static byte[] FromUIntToByteArrayOfBits(byte[] array,uint seed)
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = (byte)(seed & 1);
                seed >>= 1;
            }
            return array;
        }
    
        public void ResetRegisters()
        {
            X = FromUIntToByteArrayOfBits(X, XSeed);
            Y = FromUIntToByteArrayOfBits(Y, YSeed);
            Z = FromUIntToByteArrayOfBits(Z, ZSeed);
        }

        public bool IsInitialized()
        {
            return XSeed != 0 && YSeed != 0 && ZSeed != 0 && XStepBits != null && YStepBits != null && ZStepBits != null && InitializationVector!=0;
        }
        
    }
}
