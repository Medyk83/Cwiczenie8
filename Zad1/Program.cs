// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    enum DniTygodnia
    {
        Poniedziałek,
        Wtorek,
        Środa,
        Czwartek,
        Piątek,
        Sobota,
        Niedziela
    }

    enum EtapyPrania
    {
        WypełnianieBębna,
        WybórProgramu,
        DodawanieDetergentu,
        Pranie,
        Płukanie,
        Wirowanie,
        Suszenie
    }

    enum Posiłki
    {
        Śniadanie,
        DrugieŚniadanie,
        Obiad,
        Podwieczorek,
        Kolacja
    }

    enum BierekSzachowych
    {
        Król,
        Hetman,
        Wieża,
        Goniec,
        Skoczek,
        Pion
    }

    static void Main()
    {
        DniTygodnia dzisiejszyDzien = DniTygodnia.Wtorek;
        Console.WriteLine($"Dzisiejszy dzień to: {dzisiejszyDzien}");

        EtapyPrania obecnyEtapyPrania = EtapyPrania.Pranie;
        Console.WriteLine($"Obecny etap prania to: {obecnyEtapyPrania}");

        Posiłki dzisiejszyPosiłek = Posiłki.Obiad;
        Console.WriteLine($"Dzisiejszy posiłek to: {dzisiejszyPosiłek}");

        BierekSzachowych wybranaBierka = BierekSzachowych.Goniec;
        Console.WriteLine($"Wybrana bierka to: {wybranaBierka}");

        Console.ReadLine();
    }
}
