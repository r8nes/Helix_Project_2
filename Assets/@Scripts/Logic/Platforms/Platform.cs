using UnityEngine;

namespace Helix.Logic.Platforms
{
    public class Platform : MonoBehaviour
    {
        [SerializeField] private float _bounceForce;
        [SerializeField] private float _bounceRadius;

        public void Break()
        {
            PlatformSegment[] platformSegments = GetComponentsInChildren<PlatformSegment>();

            foreach (var segment in platformSegments)
            {
                segment.Bounce(_bounceForce, transform.position, _bounceRadius);
            }
        }
    }
}
