using HarmonyLib;
using Sandbox.Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPlugin.Patches
{
    [HarmonyPatch(typeof(MyVoxelBase), "CanPlaceInArea")]
    internal static class CanPlaceInArea_Patch
    {
        private static bool Prefix(ref bool __result)
        {
            if (Sync.MultiplayerActive)
            {
                return true;
            }
            __result = true;
            return false;
        }
    }
}
