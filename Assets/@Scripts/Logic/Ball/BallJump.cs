using Helix.Logic.Platforms;
using UnityEngine;

namespace Helix.Logic.Balls
{
    [RequireComponent(typeof(Rigidbody))]
    public class BallJump : MonoBehaviour
    {
        private Rigidbody _rigidBody;

        [SerializeField] private float _jumpForce;

        private void Start() => _rigidBody = GetComponent<Rigidbody>();

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.TryGetComponent(out PlatformSegment platformSegment))
            {
                _rigidBody.velocity = Vector3.zero;
                _rigidBody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            }
        }
    }
}
