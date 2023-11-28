using System.Linq;
using Il2Cpp;
using Il2CppAssets.Script.Util.Extensions;
using Il2CppMonomiPark.SlimeRancher.DataModel;
using Il2CppMonomiPark.World;
using MelonLoader;
using UnityEngine;

namespace WalkOnWater
{
    internal class Entry : MelonMod
    {
        public override void OnSceneWasUnloaded(int buildIndex, string sceneName)
        {
            if (sceneName != "LoadScene")
                return;

            var seaKillCube = Resources.FindObjectsOfTypeAll<GameObject>()
                .FirstOrDefault(x => x.name == "seaKillCube");
            seaKillCube.AddComponent<MeshCollider>();
        }
    }
}
