using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    class Tank
    {
        private string _name;
        private int _ammunition;
        private int _armorLevel;
        private int _maneuverabilityLevel;

        public Tank(string name)
        {
            Random random = new Random();

            _name = name;
            _ammunition = random.Next(0, 100);
            _armorLevel = random.Next(0, 100);
            _maneuverabilityLevel = random.Next(0, 100);
        }

        public string Name { get => _name; }
        public int Ammunition { get => _ammunition; }
        public int ArmorLevel { get => _armorLevel; }
        public int ManeuverabilityLevel { get => _maneuverabilityLevel; }

        public string dataToString()
        {
            string data = "";
            data += _name;
            data += "\n";

            data += $"Боекомплект: {_ammunition}";
            data += "\n";

            data += $"Уровень брони: {_armorLevel}";
            data += "\n";

            data += $"Уровень манёвренности: {_maneuverabilityLevel}";
            data += "\n";

            return data;
        }

        public static bool operator*(Tank firstTank, Tank secondTank)
        {
            int exceedingParametersNumber = 0;

            if (firstTank.Ammunition > secondTank.Ammunition)
                exceedingParametersNumber++;

            if (firstTank.ArmorLevel > secondTank.ArmorLevel)
                exceedingParametersNumber++;

            if (firstTank.ManeuverabilityLevel > secondTank.ManeuverabilityLevel)
                exceedingParametersNumber++;

            return (exceedingParametersNumber > 1)? true : false;
        }
    }
}
