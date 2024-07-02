using System;
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

        public bool EnableAutoHook { get; set; }
        public int AutoHookRequirement {  get; set; }

        public bool EnableAutoTreasureChest {  get; set; }
        public int AutoTreasureChestRequirement { get; set; }

        public bool EnableBiteTimeReduction { get; set; }
        public int BiteTimeReductionAmount { get; set; }

        public ModConfig() 
        {

            this.EnableDifficultyModifier = true;
            this.DifficultyModifier = 2.5f;

            this.EnableTackleRestoration = true;
            this.TackleRestorationChance = 5;

            this.EnableDoubleHook = true;
            this.DoubleHookChance = 1.0f;

            this.EnableAutoHook = true;
            this.AutoHookRequirement = 5;

            this.EnableAutoTreasureChest = true;
            this.AutoTreasureChestRequirement = 10;

            this.EnableBiteTimeReduction = true;
            this.BiteTimeReductionAmount = 1;
        }

    }
}
