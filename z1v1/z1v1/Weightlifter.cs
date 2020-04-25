using System;
using System.Collections.Generic;
using System.Text;

namespace CshLab5
{
    class Weightlifter : SpecificSport
    {
        private Medals _medals;
        public Weightlifter(int GoldMedal, int SilverMedal, int BronzeMedal)
        {
            _medals = new Medals(GoldMedal, SilverMedal, BronzeMedal);
        }
        public override Name GetSportName() => Name.Weightlifting;
        public override double GetResult() => _medals.GetResult();
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
            _medals.OutInfo();
        }
    }
}
