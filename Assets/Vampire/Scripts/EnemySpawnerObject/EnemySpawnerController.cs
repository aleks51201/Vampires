using System.Collections;
using UnityEngine;

namespace Vampire.EnemySpawnerObject
{
    internal class EnemySpawnerController
    {
        private EnemySpawnerView _enemySpawnerView;


        public EnemySpawnerController(EnemySpawnerView enemySpawnerView)
        {
            _enemySpawnerView = enemySpawnerView;
        }


        internal void Init()
        {
            StartCoroutinr();
        }

        internal void Update()
        {
        }

        private void Spawn()
        {
            //_enemySpawnerView.Spawn(_enemySpawnerView.EnemyViewPrefab, _enemySpawnerView.transform.position + new Vector3(_enemySpawnerView.SpawnDistance,_enemySpawnerView.SpawnDistance ));
            UnityEngine.Object.Instantiate(_enemySpawnerView.EnemyViewPrefab, _enemySpawnerView.transform.position + new Vector3(_enemySpawnerView.SpawnDistance,_enemySpawnerView.SpawnDistance ),Quaternion.identity);
        }

        private void StartCoroutinr()
        {
            _enemySpawnerView.StartCoroutine(Spawning());
        }

        private IEnumerator Spawning()
        {
            while (true)
            {
                Spawn();
                yield return new WaitForSeconds(5);
            }
        }

    }
}