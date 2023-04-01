using UnityEngine;

namespace Helix.Entity.Tower
{
    public class Tower : MonoBehaviour
    {
    }

    public class TowerBuilder : MonoBehaviour
    {
        public float CylinderScaleY => _levelCount / 2f + _startAndFinishAdditionalScale + _additionalScale / 2f;

        [SerializeField] private GameObject _cylinder;
        
        [SerializeField] private int _levelCount;
        [SerializeField] private float _additionalScale;

        SerializeField] private StartPlatform _startPlatform;
        [SerializeField] private Platform[] _platform;
        [SerializeField] private FinishPlatform _finishPlatform;

        private float _startAndFinishAdditionalScale = 0.5f;

        private void Awake()
        {
            Build();
        }

        private void Build() 
        {
            GameObject cylinder = Instantiate(_cylinder, transform);
            cylinder.transform.localPosition = new Vector3(1, CylinderScaleY,1);

            Vector3 spawnPosition = cylinder.transform.position;
            spawnPosition.y += cylinder.transform.localScale.y - _additionalScale;


        }
    }
}
