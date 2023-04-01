using Helix.Logic.Balls;
using UnityEngine;

namespace Helix.Logic.Platforms
{
    public class StartPlatform : Platform
    {
        [SerializeField] private Ball _ball;
        [SerializeField] private Transform _startPoint;

        private void Awake() => Instantiate(_ball, _startPoint.position, Quaternion.identity);
    }
}
