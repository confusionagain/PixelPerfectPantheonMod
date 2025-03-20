using HarmonyLib;
using Il2Cpp;

namespace PixelPerfect.Hooks
{
    [HarmonyPatch(typeof(EntityPlayerGameObject), nameof(EntityPlayerGameObject.NetworkStart))]
    internal static class PlayerNetworkStart
    {
        [HarmonyPostfix]
        private static void Postfix(EntityPlayerGameObject __instance)
        {
            PixelPerfect.CheckIfReady(__instance);
        }
    }
}