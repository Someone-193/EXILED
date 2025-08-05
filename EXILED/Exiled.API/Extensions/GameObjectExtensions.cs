// -----------------------------------------------------------------------
// <copyright file="GameObjectExtensions.cs" company="ExMod Team">
// Copyright (c) ExMod Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

#nullable enable
namespace Exiled.API.Extensions
{
    using Exiled.API.Features;
    using UnityEngine;

    /// <summary>
    /// A set of extensions for <see cref="GameObject"/>.
    /// </summary>
    public static class GameObjectExtensions
    {
        /// <summary>
        /// Gets the global scale of a GameObject.
        /// </summary>
        /// <param name="gameObject">The <see cref="GameObject"/> to check.</param>
        /// <returns>The global scale of the provided <see cref="GameObject"/>.</returns>
        public static Vector3 GetWorldScale(this GameObject gameObject)
        {
            Transform? parent = gameObject.transform.parent;

            if (!parent)
            {
                return gameObject.transform.localScale;
            }

            gameObject.transform.SetParent(null, true);
            Vector3 value = gameObject.transform.localScale;

            gameObject.transform.SetParent(parent, true);
            return value;
        }

        /// <summary>
        /// Sets the global scale of a GameObject.
        /// </summary>
        /// <param name="gameObject">The <see cref="GameObject"/> to modify.</param>
        /// <param name="scale">The new scale.</param>
        public static void SetWorldScale(this GameObject gameObject, Vector3 scale)
        {
            Transform? parent = gameObject.transform.parent;

            if (!parent)
            {
                gameObject.transform.localScale = scale;
                return;
            }

            gameObject.transform.SetParent(null, true);
            gameObject.transform.localScale = scale;

            gameObject.transform.SetParent(parent, true);
        }
    }
}