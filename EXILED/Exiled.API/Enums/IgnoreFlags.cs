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
        None = 0,

        Scp173 = 1,

        Scp096 = 2,

        Scp079 = 4,

        Scp049 = 8,

        RoundStart = 16,

        PlayerCount = 32,

        RoundEnd = 64,

        Respawn = 128,
    }
}