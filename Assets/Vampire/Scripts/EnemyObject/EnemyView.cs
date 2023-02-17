using UnityEngine;

namespace Vampire.EnemyObject
{
    public class EnemyView : MonoBehaviour
    {
        [SerializeField] private Transform _heroTransform;

        private EnemyController _enemyController;


        public Transform HeroTransform => _heroTransform;


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
