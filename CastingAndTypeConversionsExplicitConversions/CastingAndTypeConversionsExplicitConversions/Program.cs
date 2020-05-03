using System;

namespace CastingAndTypeConversionsExplicitConversions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            {
                sbyte variableOne = -128;
                byte variableTwo = (byte)variableOne;
                Console.WriteLine(variableTwo);

                ushort variableThree = (ushort)variableOne;
                Console.WriteLine(variableThree);

                uint variableFour = (uint)variableOne;
                Console.WriteLine(variableFour);

                ulong variableFive = (ulong)variableOne;
                Console.WriteLine(variableFive);

                char variableSix = (char)variableOne;
                Console.WriteLine(variableOne);
            }

            {

                byte variableOne = 255;
                sbyte variableTwo = (sbyte)variableOne;
                Console.WriteLine(variableTwo);

                char variableThree = (char)variableOne;
                Console.WriteLine(variableThree);
            }

            {
                short variableOne = 32767;
                sbyte variableTwo = (sbyte)variableOne;
                Console.WriteLine(variableTwo);

                byte variableThree = (byte)variableOne;
                Console.WriteLine(variableThree);

                ushort variableFour = (ushort)variableOne;
                Console.WriteLine(variableFour);

                uint variableFive = (uint)variableOne;
                Console.WriteLine(variableFive);

                ulong variableSix = (ulong)variableOne;
                Console.WriteLine(variableSix);

                char variableSeven = (char)variableOne;
                Console.WriteLine(variableSeven);
            }

            {
                ushort variableOne = 65535;
                sbyte variableTwo = (sbyte)variableOne;
                Console.WriteLine(variableTwo);

                byte variableThree = (byte)variableOne;
                Console.WriteLine(variableThree);

                short variableFour = (short)variableOne;
                Console.WriteLine(variableFour);
            }

            {
                int variableOne = -2147483648;
                sbyte variableTwo = (sbyte)variableOne;
                Console.WriteLine(variableTwo);

                byte variableThree = (byte)variableOne;
                Console.WriteLine(variableThree);

                short variableFour = (short)variableOne;
                Console.WriteLine(variableFour);

                ushort variableFive = (ushort)variableOne;
                Console.WriteLine(variableFive);

                uint variableSix = (uint)variableOne;
                Console.WriteLine(variableSix);

                ulong variableSeven = (ulong)variableOne;
                Console.WriteLine(variableSeven);
            }

            {
                uint variableOne = 4294967295;
                sbyte variableTwo = (sbyte)variableOne;
                Console.WriteLine(variableOne);

                byte variableThree = (byte)variableOne;
                Console.WriteLine(variableThree);

                short variableFour = (short)variableOne;
                Console.WriteLine(variableFour);

                ushort variableFive = (ushort)variableOne;
                Console.WriteLine(variableFive);

                int variableSix = (int)variableOne;
                Console.WriteLine(variableSix);
            }

            {
                long variableOne = 9223;
                sbyte variableTwo = (sbyte)variableOne;
                Console.WriteLine(variableTwo);

                byte variableThree = (byte)variableOne;
                Console.WriteLine(variableThree);

                short variableFour = (short)variableOne;
                Console.WriteLine(variableFour);

                ushort variableFive = (ushort)variableOne;
                Console.WriteLine(variableFive);

                int variableSix = (int)variableOne;
                Console.WriteLine(variableSix);

                uint variableSeven = (uint)variableOne;
                Console.WriteLine(variableSeven);

                ulong variableEight = (ulong)variableOne;
                Console.WriteLine(variableEight);
            }

            {
                ulong variableOne = 18_446_744_073_709_551_615;
                sbyte variableTwo = (sbyte)variableOne;
                Console.WriteLine(variableTwo);

                byte variableThree = (byte)variableOne;
                Console.WriteLine(variableThree);

                short variableFour = (short)variableOne;
                Console.WriteLine(variableFour);

                ushort variableFive = (ushort)variableOne;
                Console.WriteLine(variableFive);

                int variableSix = (int)variableOne;
                Console.WriteLine(variableSix);

                uint variableSeven = (uint)variableOne;
                Console.WriteLine(variableSeven);

                long variableEight = (long)variableOne;
                Console.WriteLine(variableEight);
            }

            {
                float variableOne = 12.3F;
                sbyte variableTwo = (sbyte)variableOne;
                Console.WriteLine(variableTwo);

                byte variableThree = (byte)variableOne;
                Console.WriteLine(variableThree);

                short variableFour = (short)variableOne;
                Console.WriteLine(variableFour);

                ushort variableFive = (ushort)variableOne;
                Console.WriteLine(variableFive);

                int variableSix = (int)variableOne;
                Console.WriteLine(variableSix);

                uint variableSeven = (uint)variableOne;
                Console.WriteLine(variableSeven);

                long variableEight = (long)variableOne;
                Console.WriteLine(variableEight);

                ulong variableNine = (ulong)variableOne;
                Console.WriteLine(variableNine);

                decimal variableTen = (decimal)variableOne;
                Console.WriteLine(variableTen);
            }

            {
                double variableOne = 123.04D;
                sbyte variableTwo = (sbyte)variableOne;
                Console.WriteLine(variableTwo);

                byte variableThree = (byte)variableOne;
                Console.WriteLine(variableThree);

                short variableFour = (short)variableOne;
                Console.WriteLine(variableFour);

                ushort variableFive = (ushort)variableOne;
                Console.WriteLine(variableFive);

                int variableSix = (int)variableOne;
                Console.WriteLine(variableSix);

                uint variableSeven = (uint)variableOne;
                Console.WriteLine(variableSeven);

                long variableEight = (long)variableOne;
                Console.WriteLine(variableEight);

                ulong variableNine = (ulong)variableOne;
                Console.WriteLine(variableNine);

                float variableTen = (float)variableOne;
                Console.WriteLine(variableTen);

                decimal variableEleven = (decimal)variableOne;
                Console.WriteLine(variableEleven);
            }

            {
                decimal variableOne = 2.1M;
                sbyte variableTwo = (sbyte)variableOne;
                Console.WriteLine(variableTwo);

                byte variableThree = (byte)variableOne;
                Console.WriteLine(variableThree);

                short variableFour = (short)variableOne;
                Console.WriteLine(variableFour);

                ushort variableFive = (ushort)variableOne;
                Console.WriteLine(variableFive);

                int variableSix = (int)variableOne;
                Console.WriteLine(variableSix);

                uint variableSeven = (uint)variableOne;
                Console.WriteLine(variableSeven);

                long variableEight = (long)variableOne;
                Console.WriteLine(variableEight);

                ulong variableNine = (ulong)variableOne;
                Console.WriteLine(variableNine);

                float variableTen = (float)variableOne;
                Console.WriteLine(variableTen);

                double variableEleven = (double)variableOne;
                Console.WriteLine(variableEleven);
            }
        }

    }
}
