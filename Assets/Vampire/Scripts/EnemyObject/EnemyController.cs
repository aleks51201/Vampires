using UnityEngine;
using Vampire.EnemyObject.Simulations;

namespace Vampire.EnemyObject
{
    public class EnemyController
    {
        private EnemyView _enemyView;
        private FollowMoveLogic _followMoveLogic;
        private DamageLogic _damageLogic;


        public EnemyController(EnemyView enemyView)
        {
            _enemyView = enemyView;
        }


        internal void Init()
        {
            _followMoveLogic = new(_enemyView.GetComponent<Rigidbody2D>(), _enemyView.transform, _enemyView.HeroTransform, _enemyView.MoveSpeed);
            _damageLogic = new();
        }

        internal void OnTriggerEnter2D(Collider2D collision)
        {
            _enemyView.Hp = _damageLogic.Damage(_enemyView.Hp, collision);
            if (_enemyView.Hp <= 0)
            {
                UnityEngine.Object.Destroy(_enemyView.gameObject);
            }
        }

        internal void Update()
        {
            _followMoveLogic.FollowMove();
        }
    }
}
