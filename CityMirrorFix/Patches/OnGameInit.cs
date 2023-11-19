using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace CityMirrorFix.Patches
{
    [HarmonyPatch(typeof(GorillaTagger), "Awake"), HarmonyWrapSafe]
    internal class OnGameInit
    {
        public static void Postfix()
        {
            GameObject.Find("Environment Objects/LocalObjects_Prefab/City").SetActive(true);
            GameObject.Find("Environment Objects/LocalObjects_Prefab/City/CosmeticsRoomAnchor/ShoppingCenterAnchor/mirrors2 (1)/CameraC").GetComponent<Camera>().cullingMask = GorillaTagger.Instance.thirdPersonCamera.transform.GetChild(0).gameObject.GetComponent<Camera>().cullingMask;
            GameObject.Find("Environment Objects/LocalObjects_Prefab/City/CosmeticsRoomAnchor/ShoppingCenterAnchor/mirrors2 (1)/CameraC").GetComponent<Camera>().farClipPlane = 500f;
        }
    }
}
