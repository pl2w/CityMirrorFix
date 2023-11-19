using BepInEx;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CityMirrorFix
{
    [BepInPlugin("pl2w.citymirrorfix", "CityMirrorFix", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        Plugin() => new Harmony("pl2w.citymirrorfix").PatchAll(Assembly.GetExecutingAssembly());
    }
}
