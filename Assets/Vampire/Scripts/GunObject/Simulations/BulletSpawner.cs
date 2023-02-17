using System.Collections;
using UnityEngine;

namespace Vampire.GunObject.Simulations
{
    public class BulletSpawner
    {
        private GameObject _bulletPrefab;
        private Transform _transform;

        public BulletSpawner(GameObject bulletPrefab, Transform transform)
        {
            _bulletPrefab = bulletPrefab;
            _transform = transform;
        }

        public IEnumerator SpawnBullet()
        {
            while (true)
            {
                UnityEngine.Object.Instantiate(_bulletPrefab, _transform.position, Quaternion.identity);
                yield return new WaitForSeconds(5f);
            }
        }
    }
}
