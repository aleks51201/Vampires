using System.Collections;
using UnityEngine;
using Vampire.BulletObject;

namespace Vampire.GunObject.Simulations
{
    public class BulletSpawner
    {
        private GameObject _bulletPrefab;
        private Transform _transform;
        private int _dmg;

        public BulletSpawner(GameObject bulletPrefab, Transform transform, int dmg)
        {
            _bulletPrefab = bulletPrefab;
            _transform = transform;
            _dmg = dmg;
        }

        public IEnumerator SpawnBullet()
        {
            while (true)
            {
                GameObject go = UnityEngine.Object.Instantiate(_bulletPrefab, _transform.position, Quaternion.identity);
                go.GetComponent<BulletView>().Dmg = _dmg;
                yield return new WaitForSeconds(5f);
            }
        }
    }
}
