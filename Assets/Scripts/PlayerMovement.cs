using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float _forwardForce;
        [SerializeField] private float _horizontalSpeed;
        [SerializeField] private float _bounceForce;
        private Rigidbody _rigidbody;
        private float _caremaDistanceY;        

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _caremaDistanceY = Camera.main.transform.position.y;
        }

        private void FixedUpdate()
        {
            var inputMousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, _caremaDistanceY);
            var worldMousePosition = Camera.main.ScreenToWorldPoint(inputMousePosition);
            
            _rigidbody.AddForce(Vector3.forward * _forwardForce * Time.fixedDeltaTime);

            if (Input.GetMouseButton(0))
            {
                var targetPoisiton = new Vector3(worldMousePosition.x, 0, transform.position.z);
                var currentPosition = new Vector3(transform.position.x, 0, transform.position.z);
                var step = _horizontalSpeed * Time.fixedDeltaTime;
                _rigidbody.MovePosition(Vector3.MoveTowards(currentPosition, targetPoisiton, step));            
            }            
        }

        public void WallBounce()
        {
            if(transform.position.x > 0)
            {
                _rigidbody.AddForce(Vector3.left * _bounceForce * Time.fixedDeltaTime, ForceMode.VelocityChange);
            }
            else
            {

            }
        }
    }
}

