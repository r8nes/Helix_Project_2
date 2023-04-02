using System.Collections;
using UnityEngine;

namespace Helix.System
{
    public interface ICoroutineRunner
    {
        Coroutine StartCoroutine(IEnumerator coroutine);
    }
}

