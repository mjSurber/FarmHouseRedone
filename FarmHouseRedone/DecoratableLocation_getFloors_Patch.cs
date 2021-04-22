using System.Collections.Generic;
using Microsoft.Xna.Framework;
using StardewValley.Locations;

namespace FarmHouseRedone
{
    internal class DecoratableLocation_getFloors_Patch
    {
        public static void Postfix(ref List<Rectangle> __result, DecoratableLocation __instance)
        {
            __result.Clear();

            var state = OtherLocations.DecoratableStates.getState(__instance);

            __result = state.getFloors();

            if (__result.Count > 0)
                return;
            else
                __result = new List<Rectangle>()
                {
                    new Rectangle(1, 3, 11, 11)
                };
        }
    }
}