﻿using Helix.Service;
using UnityEngine;

namespace Helix.Assets
{
    public interface IAssetsProvider : IService
    {
        /// <summary>
        ///  Instantiate object without position.
        /// </summary>
        /// <param name="path">Asset path direction</param>
        /// <returns>New object</returns>
        GameObject Instantiate(string path);

        /// <summary>
        ///  Instantiate object with given position.
        /// </summary>
        /// <param name="path">Asset path direction</param>
        /// <param name="point">Current location</param>
        /// <returns>New object</returns>
        GameObject Instantiate(string path, Vector2 point);
    }
}
