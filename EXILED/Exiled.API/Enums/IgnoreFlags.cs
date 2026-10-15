// -----------------------------------------------------------------------
// <copyright file="IgnoreFlags.cs" company="ExMod Team">
// Copyright (c) ExMod Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.API.Enums
{
    using System;

    /// <summary>
    /// All available ignore flags.
    /// </summary>
    [Flags]
    public enum IgnoreFlags
    {
        /// <summary>
        /// No ignored interactions.
        /// </summary>
        None = 0,

        /// <summary>
        /// Cannot trigger SCP 173.
        /// </summary>
        Scp173 = 1,

        /// <summary>
        /// Cannot trigger SCP 096.
        /// </summary>
        Scp096 = 2,

        /// <summary>
        /// Cannot be scanned by SCP 079.
        /// </summary>
        Scp079 = 4,

        /// <summary>
        /// Cannot be targeted by SCP 049's call.
        /// </summary>
        Scp049 = 8,

        /// <summary>
        /// Does not contribute to round start.
        /// </summary>
        RoundStart = 16,

        /// <summary>
        /// Does not affect player counting methods.
        /// </summary>
        PlayerCount = 32,

        /// <summary>
        /// Does not affect round end checks.
        /// </summary>
        RoundEnd = 64,

        /// <summary>
        /// Does not respawn or trigger respawns.
        /// </summary>
        Respawn = 128,

        /// <summary>
        /// An aggregate value that means the player cannot interact with any SCPs.
        /// </summary>
        SCPs = Scp173 | Scp096 | Scp079 | Scp049,

        /// <summary>
        /// An aggregate value that means the player cannot interact with round mechanics.
        /// </summary>
        RoundInteractions = RoundStart | RoundEnd | Respawn,

        /// <summary>
        /// An aggregate value that tries to ignore every interaction possible.
        /// </summary>
        All = SCPs | RoundInteractions | PlayerCount,
    }
}