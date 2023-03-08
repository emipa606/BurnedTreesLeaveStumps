using System.Reflection;
using HarmonyLib;
using Verse;

namespace BurnedTreesLeaveStumps;

[StaticConstructorOnStartup]
public static class BurnedTreesLeaveStumps
{
    static BurnedTreesLeaveStumps()
    {
        new Harmony("Mlie.BurnedTreesLeaveStumps").PatchAll(Assembly.GetExecutingAssembly());
    }
}