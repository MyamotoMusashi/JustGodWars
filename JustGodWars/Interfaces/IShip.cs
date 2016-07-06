namespace JustGodWars.Interfaces
{
    using JustGodWars.Models.Types;

    public interface IShip
    {
        string Name { get; }

        ShipType Type { get; }

        int Health { get; }

        int Damage { get; }

        int Power { get; }

        void Fire(int removedPower);

        void GetInfo();
    }
}
