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
        public int Dmg = 3;
        public int Hp = 15;


        private void Update()
        {
            _enemyController.Update();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            _enemyController.OnTriggerEnter2D(collision);
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
