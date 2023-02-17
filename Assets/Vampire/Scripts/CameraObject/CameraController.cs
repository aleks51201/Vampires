using Vampire.CameraObject.Simulations;

namespace Vampire.CameraObject
{
    public class CameraController
    {
        private CameraView _cameraView;
        private FollowLogic _followLogic;

        
        public CameraController(CameraView cameraView)
        {
            _cameraView = cameraView;
        }

        internal void Init()
        {
            _followLogic = new(_cameraView.transform,_cameraView.ObjectToFollow, _cameraView.transform.position - _cameraView.ObjectToFollow.position);
        }

        internal void Update()
        {
            _followLogic.FollowMove();
        }
    }
}
