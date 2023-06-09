using System;

using CM.Magic.MagicObject;


namespace CM.Magic.Legacy
{
    [Obsolete("代替Enumの実装待ち")]
    public enum SpellObjectControllerType
    {
        GENERATE,
        REMOVE,
        UPDATE
    }

    [Obsolete("代替Enumの実装待ち")]
    public enum SpellObjectType
    {
        NONE,
        DEBUG,
        PROJECTILE,
        AOE
    }




    public static class SpellObjectTypeExtension
    {
        [Obsolete("代替関数の実装待ち")]
        public static bool isSameType(this SpellObjectType type, BaseMagicObject spellObject)
        {
            return type == type.GetSpellObjectType(spellObject);
        }


        [Obsolete("代替関数の実装待ち")]
        public static SpellObjectType GetSpellObjectType(this SpellObjectType type, BaseMagicObject spellObject)
        {
            switch (spellObject)
            {
                case Projectile proj:
                    return SpellObjectType.PROJECTILE;
                case AreaOfEffect aoe:
                    return SpellObjectType.AOE;
                default:
                    return SpellObjectType.NONE;
            }
        }
    }
}
