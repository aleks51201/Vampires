using UnityEngine;

namespace Vampire.GunObject
{
    public class GunView:MonoBehaviour
    {
        [SerializeField] private GameObject _bulletPrefab;
        
        private GunController _gunController;

        public GameObject BulletPrefab => _bulletPrefab;
        public int Dmg = 5;


        private void Update()
        {
            _gunController.Update();
            
        }

        private void Awake()
        {
            _gunController = new(this);
            _gunController.Init();
        }
    }
}
