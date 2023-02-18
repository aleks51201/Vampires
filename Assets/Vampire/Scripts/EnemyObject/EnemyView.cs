using UnityEngine;

namespace Vampire.EnemyObject
{
    public class EnemyView : MonoBehaviour
    {
        private Transform _heroTransform;
        [SerializeField] private float _moveSpeed;

        private EnemyController _enemyController;


        //public Transform HeroTransform => _heroTransform;
        public Transform HeroTransform { get
            {
                Debug.Log($"get {_heroTransform is null}");
                return _heroTransform;
            }
            set {
                Debug.Log($"set {value}");
                _heroTransform = value;
                } }
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
                Debug.Log($"Awake {HeroTransform is null}");
        }
        private void Start()
        {
                Debug.Log($"start {HeroTransform is null}");
            _enemyController = new(this);
            _enemyController.Init();
        }

        private void OnEnable()
        {
                Debug.Log($"onEnable{HeroTransform is null}");
        }

        private void OnDisable()
        {

        }
    }
}
