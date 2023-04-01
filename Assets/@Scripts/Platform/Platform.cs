using UnityEngine;

namespace Helix.Entity.Tower
{
    public abstract class Platform : MonoBehaviour
    {
        public virtual void Break() 
        {
            PlatformSegment[] platformSegment = GetComponentsInChildren<PlatformSegment>();

            foreach (var segment in platformSegment)
            {
                
            }
        }
    }
}