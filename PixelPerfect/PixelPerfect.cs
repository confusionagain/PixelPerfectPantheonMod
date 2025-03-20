using UnityEngine;
using Il2Cpp;
using UnityEngine.SceneManagement;

namespace PixelPerfect
{
    public class PixelPerfect
    {
        private static bool isDone;

        internal static void CheckIfReady(EntityPlayerGameObject __instance)
        {
            uint networkId = __instance.NetworkId.Value;
            uint playerId = EntityPlayerGameObject.LocalPlayerId.Value;
            bool isGameScene = SceneManager.GetActiveScene().name == "Game";

            if (!isDone && networkId == playerId && networkId > 1 && isGameScene)
            {
                isDone = true;
                InitializePantheonMeter();
            }
            else if (!isGameScene || networkId <= 1)
            {
                // disable logic
            }
        }

        internal static void InitializePantheonMeter()
        {
            var hud = GameObject.Find("HudCanvas(Clone)");

            if (hud != null)
            {
                hud.GetComponent<Canvas>().pixelPerfect = true;
            }
        }
    }

}