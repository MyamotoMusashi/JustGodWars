namespace JustGodWars.Models.Ships
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using JustGodWars.Interfaces;
    using JustGodWars.Models.Types;
    using JustGodWars.Validation;

    //Note: every abstract class should have atleast one abstract member
    public abstract class Ship : IShip
    {
        internal const int MinPowerValue = 0;
        internal const int MinHealthValue = 0;
        internal const int MinDamageValue = 10;
        internal const int MinNameLengthValue = 2;

        private int power;
        private int damage;
        private int health;
        private string name;

        public int Damage
        {
            get
            {
                return this.damage;
            }

            protected set
            {
                ValidateShips.ValidateDamage(value);
                this.damage = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }

            protected set
            {
                ValidateShips.ValidateHealth(value);
                this.health = value;
            }
        }

        public int Power
        {
            get
            {
                return this.power;
            }

            protected set
            {
                ValidateShips.ValidatePower(value);

                if (value == MinPowerValue)
                {
                    // TODO: An event that will fill the power with some value on every 5 seconds or more
                }

                this.power = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                ValidateShips.ValidateName(value);
                this.name = value;
            }
        }

        public ShipType Type { get; private set; }

        public void Fire(int removedPower)
        {
            this.Power -= removedPower;

            if (this.Power < MinPowerValue)
            {
                this.Power = MinPowerValue;
            }
        }

        public abstract void GetInfo();
    }
}