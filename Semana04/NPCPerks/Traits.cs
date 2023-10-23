using System;

namespace NPCPerks
{
    [Flags]
    public enum Traits
    {
        resistente = 1 << 0,
        forte = 1 << 1,
        agil = 1 << 2,
        inteligente = 1 << 3,
        devoto = 1 << 4


    }
}