using System;
using System.Collections.Generic;
using System.Text;

namespace CshLab5
{
    class LightAthlet : SpecificSport
    {
        private Medals _medals;
        private struct LegsPower
        {
            public int LeftPower, RightPower;
        }
        LegsPower Legs;
        public LightAthlet(int GoldMedal, int SilverMedal, int BronzeMedal, int PowerOfLeftLeg, int PowerOfRightLeg)
        {
            _medals = new Medals(GoldMedal, SilverMedal, BronzeMedal);
            Legs.LeftPower = PowerOfLeftLeg;
            Legs.RightPower = PowerOfRightLeg;
        }
        public override Name GetSportName() => Name.LightAthletic;
        public override double GetResult() => _medals.GetResult();
        public static bool IsSuit(Human human)
        {
            if (human.Age < 18 || human.Age > 50) return false;
            if (human.Weight < 30 || human.Weight > 140) return false;
            if (human.Height < 120 || human.Height > 250) return false;
            return true;
        }
        public override void OutInfo()
        {
            Console.WriteLine("This person trohi like light athletic:");
            if (Legs.LeftPower > Legs.RightPower) Console.WriteLine($"His favourite left leg has {Legs.LeftPower} power");
            else Console.WriteLine($"His favourite right leg has {Legs.RightPower} power");
            _medals.OutInfo();
        }
    }
}
