using System;

namespace ConsoleApp3
{
    class RomanNumeralConv
    {
        //I, V, X, L, C, D, M

        private static void Main()
        {
            Console.WriteLine(ConvertNumerals("XIX"));
        }

        public static int ConvertNumerals(string numero)
        {
            numero = numero.ToUpper();
            for(int i = 0; i < numero.Length; i++)
            {
                char character = numero[i];

                if (i != numero.Length -1)
                {
                    if (GetNumeroValue(numero[i]) < (numero [i -1]))
                    {

                       

                        i++;
                        continue;
                    }
                }

            }
            return 0;
        }

        public static int GetNumeroValue(char val)
        {
            switch(val)
            {
                case 'I':
                    return (int)NumeroNumerals.I;
                case 'V':
                    return (int)NumeroNumerals.V;
                case 'X':
                    return (int)NumeroNumerals.X;
                case 'L':
                    return (int)NumeroNumerals.L;
                case 'C':
                    return (int)NumeroNumerals.C;
                case 'D':
                    return (int)NumeroNumerals.D;
                case 'M':
                    return (int)NumeroNumerals.M;
                default:
                    return 0;
            }
        }
  
    }
}
enum NumeroNumerals
{
    I = 1,
    V = 5,
    X = 10,
    L = 50,
    C = 100,
    D = 500,
    M = 1000
}