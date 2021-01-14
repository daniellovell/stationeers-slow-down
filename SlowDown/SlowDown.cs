using BepInEx;
using HarmonyLib;
using BepInEx.Configuration;

namespace SlowDown
{
    [BepInPlugin("SlowDown", "Slow Down Mod", "1.1.0.0")]
    public class SlowDown : BaseUnityPlugin
    {
        private ConfigEntry<string> configSlowKey;
        private ConfigEntry<string> configToggleSlowKey;
        private ConfigEntry<float> configSlowedSpeed;


        public static string SlowKey;
        public static string ToggleSlowKey;
        public static float SlowedSpeed;

        public static void ModLog(string text)
        {
            UnityEngine.Debug.Log("[Slow Down] " + text);
        }

        // Awake is called once when both the game and the plug-in are loaded
        void Awake()
        {
            HandleConfig();

            ModLog("Successfully loaded Slow Down");
            ModLog("Patching...");
            var harmony = new Harmony("SlowDown");
            harmony.PatchAll();
            ModLog("Patched");
        }

        void HandleConfig()
        {
            configSlowKey = Config.Bind("General",   // The section under which the option is shown
                                     "SlowKeyCode",  // The key of the configuration option in the configuration file
                                     "LeftControl", // The default value
                                     "The key to use to HOLD to slow down - https://docs.unity3d.com/ScriptReference/KeyCode.html"); // Description of the option to show in the config file

            SlowKey = configSlowKey.Value;

            configToggleSlowKey = Config.Bind("General",   // The section under which the option is shown
                                     "ToggleSlowKeyCode",  // The key of the configuration option in the configuration file
                                     "CapsLock", // The default value
                                     "The key to use to TOGGLE to slow down - https://docs.unity3d.com/ScriptReference/KeyCode.html"); // Description of the option to show in the config file

            ToggleSlowKey = configToggleSlowKey.Value;

            configSlowedSpeed = Config.Bind("General",   // The section under which the option is shown
                                     "SlowedSpeed",  // The key of the configuration option in the configuration file
                                     2f, // The default value
                                     "The speed to slow down to (vanilla movement speed is 0.4) "); // Description of the option to show in the config file

            SlowedSpeed = configSlowedSpeed.Value;
        }

    }
}
