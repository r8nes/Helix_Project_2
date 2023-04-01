using Helix.Logic.Platforms;
using UnityEngine;

namespace Helix.Logic.Balls
{
    public class Ball : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out PlatformSegment platformSegment))
            {
                other.GetComponentInParent<Platform>().Break();
            }
        }
    }
}
