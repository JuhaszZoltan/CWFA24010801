using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabirintusCLI
{
    internal class LabSim
    {
        private List<string> adatsorok;
        private char[,] lab;

        public bool KeresesKesz { get; set; }
        public int KijaratOszlopindex { get; }
        public int KijaratSorindex { get; }
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
            throw new NotImplementedException();
        }
        public void KiirLab()
        {
            throw new NotImplementedException();
        }
        public void Utkeres()
        {
            throw new NotImplementedException();
        }

        public LabSim(string forras)
        {
            adatsorok = new();
            BeolvasAdatsorok(forras);
            SorokSzama = adatsorok.Count;
            OszlopokSzama = adatsorok[0].Length;
            KijaratOszlopindex = OszlopokSzama - 1;
            KijaratSorindex = SorokSzama - 2;
            FeltoltLab();
        }
    }
}
