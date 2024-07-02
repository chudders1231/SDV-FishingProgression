using StardewModdingAPI;
using StardewValley;
using StardewValley.Tools;
using System;
using System.Runtime.CompilerServices;

namespace FishingProgression.framework
{
    internal class CalculateTimeUntilFishingBite
    {

        private static IMonitor Monitor;

        // call this method from your Entry class
        internal static void Initialize(IMonitor monitor)
        {
            Monitor = monitor;
        }

        internal static void calculateTimeUntilFishingBite_PostFix(ref float __result, FishingRod __instance, ref Farmer who)
        {
            float calc = Math.Clamp((Globals.Config.BiteTimeReductionAmount * who.FishingLevel) * 0.01f, 0, 1);
            float fishingTime = FishingRod.maxFishingBiteTime * (1 - calc);

            Log.Debug($"Calc: {calc} - Result: {__result * (1 - calc)}");

            __result = __result * (1 - calc);
        }
    }
}
