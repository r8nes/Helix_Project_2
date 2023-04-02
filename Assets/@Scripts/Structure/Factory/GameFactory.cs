using Defender.Assets;
using Helix.Assets;
using UnityEngine;

namespace Helix.Factory
{
    public class GameFactory : IGameFactory
    {
        private readonly IAssetsProvider _assets;

        private GameObject PlayerGameObject { get; set; }

        public GameFactory(IAssetsProvider assets)
        {
            _assets = assets;
        }

        public GameObject CreatePlayer(Vector2 initialPoint)
        {
            PlayerGameObject = AddGameObject(AssetsPath.PLAYER_PATH, initialPoint);

            return PlayerGameObject;
        }

        private GameObject AddGameObject(string prefabPath, Vector2 at)
        {
            GameObject gameObject = _assets.Instantiate(prefabPath, at);

            return gameObject;
        }

        private GameObject AddGameObject(string prefabPath)
        {
            GameObject gameObject = _assets.Instantiate(path: prefabPath);

            return gameObject;
        }
    }
}