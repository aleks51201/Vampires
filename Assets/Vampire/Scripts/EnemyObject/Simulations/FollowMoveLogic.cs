using UnityEngine;
using UnityEngine.AI;

namespace Vampire.EnemyObject.Simulations
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class FollowMoveLogic
    {
        private NavMeshAgent _navMeshAgent;
        private Transform _transform;
        private Rigidbody2D _rb;
        private Transform _targetTransform;
        private float _moveSpeed;

        public FollowMoveLogic(NavMeshAgent navMeshAgent, Transform targetTransform)
        {
            _navMeshAgent = navMeshAgent;
            _targetTransform = targetTransform;
        }

        public FollowMoveLogic(Rigidbody2D enemyRigidbody, Transform enemyTransform, Transform targetTransform, float moveSpeed)
        {
            _rb = enemyRigidbody;
            _transform = enemyTransform;
            _targetTransform = targetTransform;
            _moveSpeed = moveSpeed;
        }


        public void FollowMove()
        {
            //_navMeshAgent.SetDestination(_targetTransform.position);
            //_rb.velocity = ( _targetTransform.position- _transform.position )* _moveSpeed;
            _transform.position = Vector2.MoveTowards(_transform.position, _targetTransform.position,Time.deltaTime * _moveSpeed);
        }
    }
}
