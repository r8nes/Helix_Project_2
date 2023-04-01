using Helix.Logic.Towers;
using UnityEngine;

namespace Helix.Logic.Balls
{
    public class BallTracking : MonoBehaviour
    {
        [SerializeField] private float _length;
        [SerializeField] private Vector3 _directionOffset;

        private Ball _ball;

        private Tower _tower;
        private Vector3 _cameraPosition;
        private Vector3 _minimumBallPosition;

        private void Start()
        {
            _ball = FindObjectOfType<Ball>();
            _tower = FindObjectOfType<Tower>();

            _cameraPosition = _ball.transform.position;
            _minimumBallPosition = _ball.transform.position;

            TrackBall();
        }

        private void Update()
        {
            if (_ball.transform.position.y < _minimumBallPosition.y)
            {
                TrackBall();
                _minimumBallPosition = _ball.transform.position;
            }
        }

        private void TrackBall()
        {
            Vector3 towerPosition = _tower.transform.position;
            towerPosition.y = _ball.transform.position.y;

            _cameraPosition = _ball.transform.position;
            Vector3 direction = (towerPosition - _ball.transform.position).normalized + _directionOffset;
            _cameraPosition -= direction * _length;

            transform.position = _cameraPosition;
            transform.LookAt(_ball.transform);
        }
    }
}
