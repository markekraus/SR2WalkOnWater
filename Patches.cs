using HarmonyLib;
using Il2Cpp;
using UnityEngine;

namespace WalkOnWater
{
    [HarmonyPatch(typeof(KillOnTrigger), nameof(KillOnTrigger.OnTriggerEnter))]
    internal class KillOnTriggerOnTriggerEnterPatch : Entry
    {
        public static bool Prefix(KillOnTrigger __instance, Collider collider)
        {
            if(__instance.name == "seaKillCube" && collider.name == "PlayerControllerKCC")
                return false;

            return true;
        }
    }
}