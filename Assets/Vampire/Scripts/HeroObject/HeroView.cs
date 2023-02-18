using UnityEngine;

namespace Vampire.HeroObject
{
    public class  HeroView:MonoBehaviour
    {
        [SerializeField] private float _moveSpeed;

        private HeroController _heroController;


        public float MoveSpeed => _moveSpeed;
        public int hp = 10;


        private void Awake()
        {
            _heroController = new(this);
            _heroController.Init();
        }

        private void Update()
        {
            _heroController.Update();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            _heroController.OnCollisionEnter2D(collision);
        }

        private void OnEnable()
        {
            _heroController.OnEnable();
        }

        private void OnDisable()
        {
            _heroController.OnDisable();
        }
    }
}
