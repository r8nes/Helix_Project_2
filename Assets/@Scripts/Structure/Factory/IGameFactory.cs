using Helix.Service;
using UnityEngine;

namespace Helix.Factory
{
    public interface IGameFactory : IService
    {
        GameObject CreatTower(Vector2 initialPoint);
    }
}