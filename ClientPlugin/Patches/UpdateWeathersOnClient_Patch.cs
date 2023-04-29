using HarmonyLib;
using Sandbox.Game.Multiplayer;
using Sandbox.Game.SessionComponents;
using Sandbox.Game.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPlugin.Patches
{
    //Weather will still show up on while on a server if weather is turned off on client side, so we block server from adding weather here.
    [HarmonyPatch(typeof(MySectorWeatherComponent), "UpdateWeathersOnClient")]
    internal static class UpdateWeathersOnClient_Patch
    {
        private static bool Prefix(ref bool __result)
        {
            if (Sync.MultiplayerActive && !MySession.Static.IsUserAdmin(Sync.MyId))
            {
                return true;
            }

            return false;
        }
    }
}
