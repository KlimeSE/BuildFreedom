using Sandbox.Engine.Utils;
using Sandbox.Game;
using Sandbox.Game.World;
using Sandbox.ModAPI;
using System;
using System.Collections.Generic;
using VRage;
using VRage.Game;
using VRage.Game.Components;
using VRage.Game.ModAPI;
using VRage.Plugins;
using VRage.Utils;

namespace BuildFreedom
{
    public class BuildFreedom : IPlugin, IDisposable
    {
        public void Init(object gameInstance)
        {
            MyFakes.DISABLE_CLIPBOARD_PLACEMENT_TEST = true;
        }

        public void Update()
        {

        }

        public void Dispose()
        {
            MyFakes.DISABLE_CLIPBOARD_PLACEMENT_TEST = false;
        }
    }
}