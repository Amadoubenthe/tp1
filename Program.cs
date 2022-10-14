class AppliBytes {
    static void Main(string[] args){
        int n = 8;
        System.Console.WriteLine("Le nombre est: " + n + " valeur est " + toBinaryString(n));

        int q = BitSET(n, 3);
        System.Console.WriteLine("BitBitSET(n,3) =" + toBinaryString(q));

        int p = BitCLR(n, 3);
        System.Console.WriteLine("BitCLR(n,3) =" + toBinaryString(p));

        int t = BitCHG(n, 2);
        System.Console.WriteLine("BitCHG(n,2) =" + toBinaryString(t));

        int dd = DecalageD(n, 2);
        System.Console.WriteLine("DecalageD(n, 2)) =" + toBinaryString(dd));

        int dg = DecalageG(n, 2);
        System.Console.WriteLine("DecalageG(n, 2)) =" + toBinaryString(dg));

        int br = BitRang(n, 2);
        System.Console.WriteLine("BitRang(n, 2)) =" + toBinaryString(br));

        int r = ROL(n, 3);
        System.Console.WriteLine("ROL(n, 3) =" + toBinaryString(r));

        int ror = ROR(n, 2);
        System.Console.WriteLine("ROR(n,2) = " + toBinaryString(ror));
        

    }

    static string toBinaryString(int n)
        {
            string[] hexa = { "0000","0001","0010","0011","0100", "0101","0110","0111","1000","1001","1010", "1011","1100","1101","1110","1111" };

            string s = string.Format("{0:x}", n), res = "";

            for (int i = 0; i < s.Length; i++)
            {
                char car = (char)s[i];

                if ((car <= '9') && (car >= '0'))
                    res = res + hexa[(int)car - (int)'0'];

                if ((car <= 'f') && (car >= 'a'))
                    res = res + hexa[(int)car - (int)'a' + 10];
            }

            return res;
        }

    static int BitSET(int nbr, int num)
        { 
            int mask;
            mask = 1 << num;
            return nbr | mask;
        }
    static int BitCLR(int nbr, int num)
        { 
            int mask;
            mask = ~(1 << num);
            return nbr & mask;
        }

    static int BitCHG(int nbr, int num)
        {
            int mask;
            mask = 1 << num;
            return nbr ^ mask;
        }

    static int SetValBit(int nbr, int rang, int val)
        { 
            return val == 0 ? BitCLR(nbr, rang) : BitSET(nbr, rang);
        }
    
    static int DecalageD(int nbr, int n)
        { 
            return nbr >> n;
        }
        static int DecalageG(int nbr, int n)
        { 
            return nbr << n;
        }

    static int BitRang(int nbr, int rang)
        {
            return (nbr >> rang) % 2;
        }
    
    static int ROL(int nbr, int n)
        { 
            int C;
            int N = nbr;
            for (int i = 1; i <= n; i++)
            {
                C = BitRang(N, 31);
                N = N << 1;
                N = SetValBit(N, 0, C);
            }
            return N;
        }
    
    static int ROR(int nbr, int n)
        { 
            int C;
            int N = nbr;
            for (int i = 1; i <= n; i++)
            {
                C = BitRang(N, 0);
                N = N >> 1;
                N = SetValBit(N, 31, C);
            }
            return N;
       }
}