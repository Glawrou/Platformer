using System;
using UnityEngine;

namespace NoseAA
{
    public abstract class InputObserver : MonoBehaviour
    {
        public Action<Vector2> OnMove;
        public Action OnJump;
    }
}
