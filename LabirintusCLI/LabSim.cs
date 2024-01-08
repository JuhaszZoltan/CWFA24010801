using System.Threading;

namespace LabirintusCLI
{
    internal class LabSim
    {
        private List<string> adatsorok;
        private char[,] lab;

        public bool KeresesKesz { get; set; }
        public int KijaratOszlopIndex { get; }
        public int KijaratSorIndex { get; }
        public bool NincsMegoldas { get; set; }
        public int OszlopokSzama { get; }
        public int SorokSzama { get; }

        private void BeolvasAdatsorok(string forras)
        {
            using StreamReader sr = new(forras);
            while (!sr.EndOfStream) adatsorok.Add(sr.ReadLine());
        }
        private void FeltoltLab()
        {
            int s = 0;
            foreach (string sor in adatsorok)
            {
                int o = 0;
                foreach (char karakter in sor)
                {
                    lab[s, o] = karakter;
                    o++;
                }
                s++;
            }
        }
        public void KiirLab()
        {
            for (int s = 0; s < lab.GetLength(0); s++)
            {
                for (int o = 0; o < lab.GetLength(1); o++)
                {
                    Console.Write(lab[s,o]);
                }
                Console.Write("\n");
            }
        }
        public void Utkeres()
        {
            Thread.Sleep(3000);
            Console.Clear();
            KiirLab();

            bool keresesKesz = false;
            bool nincsMegoldas = false;
            int r = 1;
            int c = 0;
            while (!keresesKesz && !nincsMegoldas)
            {
                Console.SetCursorPosition(c, r);

                Console.ForegroundColor = ConsoleColor.Green;
                lab[r, c] = 'o';
                Console.Write('o');
                if (lab[r, c + 1] == ' ') c++;
                else if (lab[r + 1, c] == ' ') r++;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    lab[r, c] = '-';
                    Console.Write('-');
                    if (lab[r, c - 1] == 'o') c--;
                    else r--;
                }
                keresesKesz = r == KijaratSorIndex && c == KijaratOszlopIndex;
                if (keresesKesz)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    lab[r, c] = 'o';
                    Console.Write('o');
                }
                nincsMegoldas = r == 1 && c == 0;
                Thread.Sleep(500);
            }
        }

        public LabSim(string forras)
        {
            adatsorok = new();
            BeolvasAdatsorok(forras);
            SorokSzama = adatsorok.Count;
            OszlopokSzama = adatsorok[0].Length;
            KijaratOszlopIndex = OszlopokSzama - 1;
            KijaratSorIndex = SorokSzama - 2;
            lab = new char[SorokSzama, OszlopokSzama];
            FeltoltLab();
        }
    }
}
