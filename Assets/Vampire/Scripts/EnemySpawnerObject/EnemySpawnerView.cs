using UnityEngine;

namespace Vampire.EnemySpawnerObject
{
    public class EnemySpawnerView:MonoBehaviour
    {
        [SerializeField] private float _spawnDistance;
        [SerializeField] private GameObject _enemyViewPrefab;

        private EnemySpawnerController _enemySpawnerController;


        public GameObject EnemyViewPrefab => _enemyViewPrefab;
        public float SpawnDistance => _spawnDistance;


/*        public void Spawn(GameObject go, Vector2 position)
        {
            Instantiate(go, position, Quaternion.identity);
        }
*/
        private void Update()
        {
            _enemySpawnerController.Update();
        }

        private void Awake()
        {
            _enemySpawnerController = new(this);
            _enemySpawnerController.Init();
        }

        private void OnEnable()
        {
            
        }

        private void OnDisable()
        {
            
        }
    }
}
