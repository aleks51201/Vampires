using System;
using Vampire.GunObject.Simulations;

namespace Vampire.GunObject
{
    internal class GunController
    {
        private GunView _gunView;
        private BulletSpawner _bulletSpawner;


        public GunController(GunView gunView)
        {
            _gunView = gunView;
        }

        internal void Init()
        {
            _bulletSpawner = new(_gunView.BulletPrefab,_gunView.transform,_gunView.Dmg);
            _gunView.StartCoroutine(_bulletSpawner.SpawnBullet());
        }

        internal void Update()
        {
        }

    }
}