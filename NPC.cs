using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initialization
{
    class Player
    {
        public string ?Name { get; }
        public string ?Behavior { get; private set; }
        public bool IsHungry { get; set; }
        public bool IsThirsty { get; set; }
        public bool IsTired { get; set; }
        public bool IsDead { get; set; }
        public int Age { get; set; }
        public int Health { get; set; } = 100;
        public int Hunger { get; set; } = 100;
        public int Thirst { get; set; }
        public int Energy { get; set; }
        public int DaysAlive { get; set; }
        public int DaysSinceEaten { get; set; }
        public int DaysSinceDrank { get; set; }
        public int DaysSinceSlept { get; set; }

    }
}
