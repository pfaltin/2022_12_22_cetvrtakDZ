// Sučelje (eng.: Interface)    - predstavlja nacrt klase
//                              - može sadržavati samo deklarirane metode i svojstva (atribute ne može)
//                              - interfejs -> ŠTO treba implementirati klasa koja ga nasljeđuje
//                              - klasa koja nasljeđuje interfejs -> KAKO nešto implementirati
//                              - jedna klasa može naslijediti više interfejsa

namespace Banka.Data.Interfejsi
{
    internal interface IRacunBanke
    {
        decimal Saldo { get; }
        string IspisiSaldo();
        void Uplata(decimal iznos);
        void Isplata(decimal iznos);

    }
}
