﻿using System.Diagnostics.CodeAnalysis;

namespace NosCore.Shared.Enumerations.Character
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public enum CharacterRelationType : short
    {
        Blocked = -1,
        Friend = 0,
        HiddenSpouse = 2,
        Spouse = 5
    }
}