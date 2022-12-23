namespace Banka.Data.Interfejsi
{
    internal interface ITekuciRacun
    {
        bool DozvoljenMinus { get; set; }
        decimal MaxDozvoljenMinus { get; set; }

    }
}
