using HarmonyLib;
using RimWorld;
using Verse;

namespace BurnedTreesLeaveStumps;

[HarmonyPatch(typeof(Plant), "Kill")]
public static class Plant_Kill
{
    public static void Prefix(DamageInfo? dinfo, Plant __instance)
    {
        if (dinfo != null && dinfo.Value.Def == DamageDefOf.Flame)
        {
            __instance.TrySpawnStump(PlantDestructionMode.Flame);
        }
    }
}