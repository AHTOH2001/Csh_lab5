using System;
using System.Collections.Generic;
using System.Text;

namespace CshLab5
{
    class LightAthlet : SpecificSport
    {
        private int GoldMedal, SilverMedal, BronzeMedal;        
        private struct LegsPower
        {
            public int LeftPower, RightPower;
        }
        LegsPower Legs;
        
        public LightAthlet(int _GoldMedal, int _SilverMedal, int _BronzeMedal,int _PowerOfLeftLeg,int _PowerOfRightLeg)
        {
            GoldMedal = _GoldMedal;
            SilverMedal = _SilverMedal;
            BronzeMedal = _BronzeMedal;
            Legs.LeftPower = _PowerOfLeftLeg;
            Legs.RightPower = _PowerOfRightLeg;
        }
        public override string GetSportName() => "Light Athletic";
        public override double GetResult() => GoldMedal * 3 + SilverMedal * 2 + BronzeMedal;
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
            if (GoldMedal != 0)
                Console.WriteLine($"number of gold medals: {GoldMedal}");
            if (SilverMedal != 0)
                Console.WriteLine($"number of silver medals: {SilverMedal}");
            if (BronzeMedal != 0)
                Console.WriteLine($"number of bronze medals: {BronzeMedal}");            
        }
    }
}
