using UnityEngine;
using Vampire.BulletObject;

namespace Vampire.EnemyObject.Simulations
{
    public class DamageLogic
    {
        public DamageLogic()
        {

        }

        public int Damage(int enemyHp,Collider2D collider)
        {
            return enemyHp - collider.gameObject.GetComponent<BulletView>().Dmg;
        }
    }
}
