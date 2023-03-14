using UnityEngine;

namespace Assets.Scripts
{
    public class CameraFollowing : MonoBehaviour
    {
        [SerializeField] private PlayerMovement _followTarget;
        [SerializeField] private float _distance;
        [SerializeField] private float _forwardSpeed;       
       
        private void Update()
        {
            var targetCoordinates = new Vector3(transform.position.x, _distance, _followTarget.transform.position.z);
            var step = _forwardSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetCoordinates, step);
        }
    }
}
