namespace PractichTRI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для того чтобы сменить октаву, нажмите: F2 или F3");
            int[] oct = new int[13];
            ConsoleKeyInfo key;
            oct = octava(1);
            do
            {
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.F2)
                {
                    oct = octava(1);
                }
                if (key.Key == ConsoleKey.F3)
                {
                    oct = octava(2);
                }
                beepoo(oct, key);
            }
            while (key.Key != ConsoleKey.Escape);
        }
        static int[] octava(int num)
        {
            int[] octav = new int[13];
            if (num == 1)
            {
                Console.WriteLine("Вторая октава");
                octav[1] = 65; octav[2] = 69; octav[3] = 73; octav[4] = 78; octav[5] = 82; octav[6] = 87; octav[7] = 92; octav[8] = 98; octav[9] = 103; octav[10] = 110; octav[11] = 116; octav[12] = 123;
                return octav;
            }
            Console.WriteLine("Третья октава");
            octav[1] = 130; octav[2] = 139; octav[3] = 147; octav[4] = 156; octav[5] = 165; octav[6] = 175; octav[7] = 185; octav[8] = 196; octav[9] = 208; octav[10] = 220; octav[11] = 233; octav[12] = 247;
            return octav;


        }
        static void beepoo(int[] oc, ConsoleKeyInfo K)
        {
            if (K.Key == ConsoleKey.A)
            {
                Console.Beep(oc[1], 100);
            };
            if (K.Key == ConsoleKey.W)
            {
                Console.Beep(oc[2], 100);
            };
            if (K.Key == ConsoleKey.S)
            {
                Console.Beep(oc[3], 100);
            };
            if (K.Key == ConsoleKey.E)
            {
                Console.Beep(oc[4], 100);
            };
            if (K.Key == ConsoleKey.D)
            {
                Console.Beep(oc[5], 100);
            };
            if (K.Key == ConsoleKey.F)
            {
                Console.Beep(oc[6], 100);
            };
            if (K.Key == ConsoleKey.T)
            {
                Console.Beep(oc[7], 100);
            };
            if (K.Key == ConsoleKey.G)
            {
                Console.Beep(oc[8], 100);
            };
            if (K.Key == ConsoleKey.Y)
            {
                Console.Beep(oc[9], 100);
            };
            if (K.Key == ConsoleKey.H)
            {
                Console.Beep(oc[10], 100);
            };
            if (K.Key == ConsoleKey.U)
            {
                Console.Beep(oc[11], 100);
            };
            if (K.Key == ConsoleKey.J)
            {
                Console.Beep(oc[12], 100);
            };

        }

    }
}
