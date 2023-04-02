using Defender.Assets;
using Helix.Assets;
using Helix.Logic.Towers;
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

        public GameObject CreatTower(Vector2 initialPoint)
        {
            GameObject cylinder = CreateCylinder();

            PlayerGameObject = AddGameObject(AssetsPath.TOWER_PATH, initialPoint);
            PlayerGameObject.GetComponent<TowerBuilder>().Construct(cylinder);

            return PlayerGameObject;
        }

        private GameObject CreateCylinder() 
        {
            GameObject cylinder = AddGameObject(AssetsPath.BASE_CYLINDER_PATH);
            return cylinder;
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