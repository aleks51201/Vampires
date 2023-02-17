using UnityEngine;

namespace Vampire.CameraObject.Simulations
{
    public class FollowLogic
    {
        private Transform _transform;
        private Transform _objFollowTransform;
        private Vector3 _deltaPos;

        
        public FollowLogic(Transform transform, Transform objFollowTransform, Vector3 deltaPos)
        {
            _transform = transform;
            _objFollowTransform = objFollowTransform;
            _deltaPos = deltaPos;
        }


        public void FollowMove()
        {
            _transform.position = _objFollowTransform.position + _deltaPos;
        }
    }
}
