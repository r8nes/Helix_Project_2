using Helix.Logic.Platforms;
using UnityEngine;

namespace Helix.Logic.Towers
{
    public class TowerBuilder : MonoBehaviour
    {
        [SerializeField] private int _levelCount;
        [SerializeField] private float _additionalScale;
        [SerializeField] private GameObject _cylinder;

        [Header("Platforms")]
        [Space]
        [SerializeField] private Platform[] _platform;
        [SerializeField] private StartPlatform _startPlatform;
        [SerializeField] private FinishPlatform _finishPlatform;

        private float _startAndFinishAdditionalScale = 0.5f;

        public float CylinderScaleY => _levelCount / 2f + _startAndFinishAdditionalScale + _additionalScale / 2f;

        private void Awake() => Build();

        private void Build()
        {
            GameObject cylinder = Instantiate(_cylinder, transform);
            cylinder.transform.localScale = new Vector3(1, CylinderScaleY, 1);

            Vector3 spawnPosition = cylinder.transform.position;
            spawnPosition.y += cylinder.transform.localScale.y - _additionalScale;

            SpawnPlatform(_startPlatform, ref spawnPosition, cylinder.transform);

            for (int i = 0; i < _levelCount; i++)
            {
                SpawnPlatform(
                    _platform[Random.Range(0, _platform.Length)], ref spawnPosition, cylinder.transform);
            }

            SpawnPlatform(_finishPlatform, ref spawnPosition, cylinder.transform);
        }

        private void SpawnPlatform(Platform platform, ref Vector3 spawnPosition, Transform parent)
        {
            platform.transform.localScale = new Vector3(1, 0.2f, 1);
            Instantiate(platform, spawnPosition, Quaternion.Euler(0, Random.Range(0, 360), 0), parent);
            spawnPosition.y -= 1;
        }
    }
}
