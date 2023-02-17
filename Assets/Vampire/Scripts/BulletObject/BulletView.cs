using UnityEngine;

namespace Vampire.BulletObject
{
    public class BulletView: MonoBehaviour
    {
        private BulletController _bulletController;


        private void Update()
        {
            _bulletController.Update();
        }

        private void Awake()
        {
            _bulletController = new(this);
            _bulletController.Init();
        }

        private void OnEnable()
        {
            _bulletController.OnEnable();
        }

        private void OnDisable()
        {
            _bulletController.OnDisable();
        }
    }
}
