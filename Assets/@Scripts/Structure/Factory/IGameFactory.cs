using Helix.Service;
using UnityEngine;

namespace Helix.Factory
{
    public interface IGameFactory : IService
    {
        GameObject CreatePlayer(Vector2 initialPoint);
    }
}