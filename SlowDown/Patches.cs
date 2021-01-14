using System;
using System.Linq;
using Assets.Scripts;
using Assets.Scripts.Voxel;
using HarmonyLib;

using System.Reflection;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

using Assets.Scripts.Objects.Items;
using System.Reflection.Emit;
using Assets.Scripts.GridSystem;
using HarmonyLib.Tools;
using Assets.Scripts.Objects;
using Assets.Scripts.Objects.Electrical;

namespace SlowDown
{

    /// <summary>
    /// Alter ore drop quantities based on their world position
    /// </summary>
    [HarmonyPatch(typeof(MovementController), "MovementHandler")]
    public class MovementController_MovementHandler
    {
        private static bool isSlowToggled = false;

        static void Prefix(MovementController __instance)
        {
            if (KeyManager.GetButtonDown((KeyCode)Enum.Parse(typeof(KeyCode), SlowDown.ToggleSlowKey)))
            {
                isSlowToggled = !isSlowToggled;
            }

            if (KeyManager.GetButton((KeyCode)Enum.Parse(typeof(KeyCode), SlowDown.SlowKey)))
            {
                if (isSlowToggled)
                {
                    __instance.MovementForce = 0.2f;
                    __instance.CharacterMaxSpeed = 4f;
                }
                else
                {
                    __instance.MovementForce = SlowDown.SlowedSpeed / 10f;
                    __instance.CharacterMaxSpeed = SlowDown.SlowedSpeed;
                }
                
            }
            else
            {
                if(isSlowToggled)
                {
                    __instance.MovementForce = SlowDown.SlowedSpeed / 10f;
                    __instance.CharacterMaxSpeed = SlowDown.SlowedSpeed;
                }
                else
                {
                    __instance.MovementForce = 0.2f;
                    __instance.CharacterMaxSpeed = 4f;
                }
                
            }
        }
    }


}
