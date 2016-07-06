namespace JustGodWars.Validation
{
    using System;

    using JustGodWars.Models.Ships;

    internal class ValidateShips
    {
        // base
        public static void ValidateName(string value)
        {
            if (value.Length < Ship.MinNameLengthValue)
            {
                throw new ArgumentOutOfRangeException(ErrorMessage.ShipInvalidNameLength);
            }
        }

        public static void ValidatePower(int value)
        {
            if (value == Ship.MinPowerValue)
            {
                throw new InvalidOperationException(ErrorMessage.ShipPowerError);
            }
        }

        public static void ValidateDamage(int value)
        {
            if (value == Ship.MinDamageValue)
            {
                throw new InvalidOperationException(ErrorMessage.ShipPowerError);
            }
        }

        public static void ValidateHealth(int value)
        {
            if (value == Ship.MinHealthValue)
            {
                throw new InvalidOperationException(ErrorMessage.ShipPowerError);
            }
        }
    }
}