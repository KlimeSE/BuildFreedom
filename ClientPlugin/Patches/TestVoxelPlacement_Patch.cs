﻿using HarmonyLib;
using Sandbox.Game.Entities;
using Sandbox.Game.Multiplayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPlugin.Patches
{
    [HarmonyPatch(typeof(MyCubeGrid), nameof(MyCubeGrid.TestVoxelPlacement))]
    internal static class TestVoxelPlacement_Patch
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
