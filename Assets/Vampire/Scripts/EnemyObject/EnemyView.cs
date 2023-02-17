using UnityEngine;

namespace Vampire.EnemyObject
{
    public class EnemyView : MonoBehaviour
    {
        [SerializeField] private Transform _heroTransform;
        [SerializeField] private float _moveSpeed;

        private EnemyController _enemyController;


        public Transform HeroTransform => _heroTransform;
        public float MoveSpeed => _moveSpeed;


        private void Update()
        {
            _enemyController.Update();
        }

        private void Awake()
        {
            _enemyController = new(this);
            _enemyController.Init();
        }

        private void OnEnable()
        {

        }

        private void OnDisable()
        {

        }
    }
}
