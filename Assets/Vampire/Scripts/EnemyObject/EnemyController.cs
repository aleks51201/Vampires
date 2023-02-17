using UnityEngine.AI;
using Vampire.EnemyObject.Simulations;

namespace Vampire.EnemyObject
{
    public class EnemyController
    {
        private EnemyView _enemyView;
        private FollowMoveLogic _followMoveLogic;


        public EnemyController(EnemyView enemyView)
        {
            _enemyView = enemyView;
        }


        internal void Init()
        {
            _followMoveLogic = new(_enemyView.GetComponent<NavMeshAgent>(), _enemyView.HeroTransform);
        }

        internal void Update()
        {
        }
    }
}
