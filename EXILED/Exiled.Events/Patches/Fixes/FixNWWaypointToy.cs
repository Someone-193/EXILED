// -----------------------------------------------------------------------
// <copyright file="FixNWWaypointToy.cs" company="ExMod Team">
// Copyright (c) ExMod Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.Events.Patches.Fixes
{
    using AdminToys;
    using HarmonyLib;
    using InventorySystem;
    using Mirror;

    using UnityEngine;

    /// <summary>
    /// Patches <see cref="InventoryExtensions.ServerDropAmmo(Inventory, ItemType, ushort, bool)"/> delegate.
    /// Fix than NW don't put worldPositionStays to true <see cref="Transform.SetParent(UnityEngine.Transform, bool)"/>.
    /// </summary>
    [HarmonyPatch(typeof(AdminToyBase), nameof(AdminToyBase.UpdateParent))]
    internal class FixNWWaypointToy
    {
#pragma warning disable SA1313 // Parameter names should begin with lower-case letter
        private static void Prefix(AdminToyBase __instance)
        {
            NetworkIdentity networkIdentity;
            if (__instance._clientParentId != 0U && NetworkClient.spawned.TryGetValue(__instance._clientParentId, out networkIdentity))
            {
                __instance.CachedTransform.SetParent(networkIdentity.transform, true);
                return;
            }

            __instance.CachedTransform.SetParent(null, true);
        }
    }
}
