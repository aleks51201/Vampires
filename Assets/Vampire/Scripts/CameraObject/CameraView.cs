using UnityEngine;

namespace Vampire.CameraObject
{
    public class CameraView: MonoBehaviour
    {
        [SerializeField] private Transform objectToFollow;

        private CameraController _cameraController;


        private void Update()
        {
            _cameraController.Update();
        }

        private void Awake()
        {
            _cameraController = new(this);
            _cameraController.Init();
        }

        private void OnEnable()
        {
            
        }

        private void OnDisable()
        {
            
        }
    }
}
