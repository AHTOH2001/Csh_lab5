using System;
using System.Collections.Generic;
using System.Text;

namespace CshLab5
{
    class Weightlifter : SpecificSport
    {
        private int GoldMedal, SilverMedal, BronzeMedal;
        public Weightlifter(int _GoldMedal, int _SilverMedal, int _BronzeMedal)
        {
            GoldMedal = _GoldMedal;
            SilverMedal = _SilverMedal;
            BronzeMedal = _BronzeMedal;
        }
        public override string GetSportName() => "Weightlifting";        
        public override double GetResult() => GoldMedal * 3 + SilverMedal * 2 + BronzeMedal;
        public static bool IsSuit(Human human)
        {
            if (human.Age < 18 || human.Age > 50) return false;
            if (human.Weight < 60 || human.Weight > 400) return false;
            if (human.Height < 130 || human.Height > 250) return false;            
            return true;
        }
        public override void OutInfo()
        {
            Console.WriteLine("This person trohi like potygat' metal:");            
            if (GoldMedal != 0)
                Console.WriteLine($"number of gold medals: {GoldMedal}");
            if (SilverMedal != 0)
                Console.WriteLine($"number of silver medals: {SilverMedal}");
            if (BronzeMedal != 0)
                Console.WriteLine($"number of bronze medals: {BronzeMedal}");
        }
    }
}
