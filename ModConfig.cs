﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingProgression
{
    public sealed class ModConfig
    {

        public bool EnableDifficultyModifier { get; set; }
        public float DifficultyModifier { get; set; }

        public bool EnableTackleRestoration { get; set; }
        public int TackleRestorationChance { get; set; }

        public bool EnableDoubleHook { get; set; }
        public float DoubleHookChance { get; set; }

        public ModConfig() 
        {

            this.EnableDifficultyModifier = true;
            this.DifficultyModifier = 2.5f;

            this.EnableTackleRestoration = true;
            this.TackleRestorationChance = 5;

            this.EnableDoubleHook = true;
            this.DoubleHookChance = 1.0f;
        }

    }
}
