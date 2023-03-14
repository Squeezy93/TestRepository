using UnityEngine;

namespace Assets.Scripts
{
    public class Wall : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            if (!collision.collider.TryGetComponent(out PlayerMovement player)) return;
            Debug.Log("BounceForce");
            player.WallBounce();
        }
        private void OnCollisionStay(Collision collision)
        {
            if (!collision.collider.TryGetComponent(out PlayerMovement player)) return;
            Debug.Log("BounceForce");
            player.WallBounce();
        }
    }
}