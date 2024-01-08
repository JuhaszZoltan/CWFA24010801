using LabirintusCLI;

LabSim lab = new(@"..\..\..\src\Lab2.txt");
Console.WriteLine("5. feladat: labirintus adatai\n" +
    $"\tSorok száma: {lab.SorokSzama}\n" +
    $"\tOszlopok száma: {lab.OszlopokSzama}\n" +
    $"\tKijárat indexe: sor: {lab.KijaratSorIndex} oszlop: {lab.KijaratOszlopIndex}");
Console.WriteLine("6. feladat: a labirintus");
lab.KiirLab();
lab.Utkeres();
