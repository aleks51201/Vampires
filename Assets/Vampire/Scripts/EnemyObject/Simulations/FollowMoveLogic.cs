using UnityEngine;
using UnityEngine.AI;

namespace Vampire.EnemyObject.Simulations
{
    public class FollowMoveLogic
    {
        private NavMeshAgent _navMeshAgent;
        private Transform _targetTransform;

        public FollowMoveLogic(NavMeshAgent navMeshAgent, Transform targetTransform)
        {
            _navMeshAgent = navMeshAgent;
            _targetTransform = targetTransform;
        }


        public void FollowMove()
        {
            _navMeshAgent.SetDestination(_targetTransform.position);
        }
    }
}
