using UnityEngine;

namespace Vampire.Data
{
    [System.Serializable]
    public struct HeroData
    {
        public string Name;
        public int LvlForOpen;
        public int Hp;
        public float MoveSpeed;
        public float AttackRate;
    }
}
