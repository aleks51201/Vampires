using UnityEngine;

namespace Vampire.HeroObject
{
    public class  HeroView:MonoBehaviour
    {
        [SerializeField] private float _moveSpeed;

        private HeroController _heroController;


        public float MoveSpeed => _moveSpeed;


        private void Awake()
        {
            _heroController = new(this);
            _heroController.Init();
        }

        private void Update()
        {
            _heroController.Update();
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
