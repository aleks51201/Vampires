using UnityEngine;
using Vampire.EnemyObject;

namespace Vampire.HeroObject.Simulations
{
    public class DamageLogic
    {
        public DamageLogic()
        {

        }

        public int Damage(int heroHp,Collision2D collider)
        {
            return heroHp - collider.gameObject.GetComponent<EnemyView>().Dmg;
        }
    }
}
