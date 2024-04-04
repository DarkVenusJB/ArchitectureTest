using UnityEngine;

namespace CodeBase.CameraLogic
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField] private float rotationAngleX; 
        [SerializeField] private int distance; 
        [SerializeField] private float offsetY;
        
        private Transform _following;

        private void LateUpdate()
        {
            if(_following == null)
                return;

            Quaternion rotation = Quaternion.Euler(rotationAngleX, 0, 0);
            
            Vector3 position = rotation * new Vector3(0, 0, -distance) + FollowingPoinPosition();

            transform.position = position;
            transform.rotation = rotation;
        }

        public void Follow(GameObject following) => 
            _following = following.transform;

        private Vector3 FollowingPoinPosition()
        {
            Vector3 followingPosition = _following.position;
            followingPosition.y = offsetY;
            
            return followingPosition;
        }
    }
}
