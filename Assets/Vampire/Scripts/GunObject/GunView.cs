using UnityEngine;

namespace Vampire.GunObject
{
    public class GunView:MonoBehaviour
    {
        private GunController _gunController;


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
