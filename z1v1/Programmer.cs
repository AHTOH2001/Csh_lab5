using System;
using System.Collections.Generic;
using System.Text;

namespace CshLab5
{
    class Programmer : SpecificSport
    {
        private readonly int _thirdDiplomaObl;
        private readonly int _secondDiplomaObl;
        private readonly int _firstDiplomaObl;
        private readonly int _thirdDiplomaResp;
        private readonly int _secondDiplomaResp;
        private readonly int _firstDiplomaResp;

        private double _klacSpeed;

        public Programmer(Regions region, int thirdDiplomaResp, int secondDiplomaResp, int firstDiplomaResp, int thirdDiplomaObl = 0, int secondDiplomaObl = 0, int firstDiplomaObl = 0, double klacSpeed = 0)
        {
            _region = region;
            _thirdDiplomaObl = thirdDiplomaObl;
            _secondDiplomaObl = secondDiplomaObl;
            _firstDiplomaObl = firstDiplomaObl;
            _thirdDiplomaResp = thirdDiplomaResp;
            _secondDiplomaResp = secondDiplomaResp;
            _firstDiplomaResp = firstDiplomaResp;
            _klacSpeed = klacSpeed;
        }
        public enum Regions
        {
            Minsk,
            Brest,
            Gomel,
            Mogilel,
            Grodno,
            Vitebsk
        }
        private readonly Regions _region;
        public override Name GetSportName() => Name.SportProgramming;
        public override double GetResult() => _thirdDiplomaResp + _secondDiplomaResp * 2 + _firstDiplomaResp * 3 + _thirdDiplomaObl * 0.2 + _secondDiplomaObl * 0.5 + _firstDiplomaObl * 0.8;
        public static bool IsSuit(Human human)
        {
            if (human.Age < 6 || human.Age > 30) return false;
            if (Human.FixName(human.Name) == "Vikusha") return false;
            return true;
        }
        public override void OutInfo()
        {
            Console.Write("This person trohi like sport programming");
            if (_klacSpeed != 0) Console.WriteLine($" and do klac klac with speed {_klacSpeed} per second:");
            else Console.WriteLine(":");
            if (_thirdDiplomaObl != 0)
                Console.WriteLine($"number of diplomas of the third degree in {_region} regional stage: {_thirdDiplomaObl}");
            if (_secondDiplomaObl != 0)
                Console.WriteLine($"number of diplomas of the second degree in {_region} regional stage: {_secondDiplomaObl}");
            if (_firstDiplomaObl != 0)
                Console.WriteLine($"number of diplomas of the first degree in {_region} regional stage: {_firstDiplomaObl}");
            if (_thirdDiplomaResp != 0)
                Console.WriteLine($"number of diplomas of the third degree in republican stage: {_thirdDiplomaResp}");
            if (_secondDiplomaResp != 0)
                Console.WriteLine($"number of diplomas of the second degree in republican stage: {_secondDiplomaResp}");
            if (_firstDiplomaResp != 0)
                Console.WriteLine($"number of diplomas of the first degree in republican stage: {_firstDiplomaResp}");
        }
    }
}
