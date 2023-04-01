using UnityEngine;

namespace Helix.Logic.Towers
{
    [RequireComponent(typeof(Rigidbody))]
    public class TowerRotator : MonoBehaviour
    {
        [SerializeField] private float _rotateSpeed;

        private Rigidbody _rigidbody;

        private void Start() => _rigidbody = GetComponent<Rigidbody>();

        private void Update()
        {
#if UNITY_EDITOR
            float direction = Input.GetAxisRaw("Horizontal");
            _rigidbody.AddTorque(Vector3.up * direction * Time.deltaTime * _rotateSpeed, ForceMode.Impulse);
#endif

#if UNITY_ANDROID
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                float torque = touch.deltaPosition.x * Time.deltaTime * _rotateSpeed;
                _rigidbody.AddTorque(Vector3.up * torque);
            }
        }
#endif
        }
    }
}
