using System.Collections;
using UnityEngine;

namespace Vampire.GunObject.Simulations
{
    public class BulletSpawner
    {
        private GameObject _bulletPrefab;

        public BulletSpawner(GameObject bulletPrefab)
        {
            _bulletPrefab = bulletPrefab;
        }

        public IEnumerator SpawnBullet()
        {
            while (true)
            {
                UnityEngine.Object.Instantiate(_bulletPrefab);
                yield return new WaitForSeconds(1f);
            }
        }
    }
}
