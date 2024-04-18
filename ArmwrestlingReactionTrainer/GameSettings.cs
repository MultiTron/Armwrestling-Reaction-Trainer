using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmwrestlingReactionTrainer
{
    public class GameSettings
    {
        private int duration;
        private int minInterval;
        private int maxInterval;

        public bool IsAudible { get; set; }
        public int Duration { get => duration; set => duration = value * 60000; }       //
        public int MinInterval { get => minInterval; set => minInterval = value * 1000; }    //  Miliseconds
        public int MaxInterval { get => maxInterval; set => maxInterval = value * 1000; }    //
        public GameSettings()
        {
            IsAudible = true;
            Duration = 5;
            MinInterval = 15;
            MaxInterval = 25;
        }
    }
}
