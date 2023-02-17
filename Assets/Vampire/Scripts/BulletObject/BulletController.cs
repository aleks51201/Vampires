using System.Collections;
using UnityEngine;

namespace Vampire.BulletObject
{
    internal class BulletController
    {
        private BulletView _bulletView;
        private Coroutine _currentCoroutine;
        private bool _isLife;


        public BulletController(BulletView bulletView)
        {
            _bulletView = bulletView;
        }

        internal void Init()
        {
        }

        private IEnumerator StartLife()
        {
            _isLife = true;
            float time = 0;
            while (time < 200)
            {
                yield return new WaitForSeconds(0.01f);
                time++;
            }
            EndLife();
        }

        private void BulletFly()
        {
            if (_isLife)
            {
                //_bulletView.transform.position = new Vector3(_bulletView.transform.position.x + Time.deltaTime, 0);
                //_bulletView.transform.Translate(Vector3.forward * 10 * Time.deltaTime);
                _bulletView.transform.position = new Vector2(_bulletView.transform.position.x + 1 * Time.deltaTime,_bulletView.transform.position.y);

            }
        }

        private void EndLife()
        {
            _isLife = false;
            UnityEngine.Object.Destroy(_bulletView.gameObject);
        }

        internal void Update()
        {
            BulletFly();
        }

        internal void OnEnable()
        {
            _bulletView.StartCoroutine(StartLife());
        }

        internal void OnDisable()
        {
        }
    }
}