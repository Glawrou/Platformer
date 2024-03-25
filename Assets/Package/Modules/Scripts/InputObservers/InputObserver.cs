using System;
using UnityEngine;

namespace NoseAA
{
    public abstract class InputObserver : MonoBehaviour
    {
        public Action<Vector2> OnMove;
        public Action OnJump;
        public Action OnSit;
        public Action OnAttack;
        public Action OnCancel;

        protected void CheckButton(string button, Action action)
        {
            if (Input.GetButtonDown(button))
            {
                action?.Invoke();
            }
        }

        protected void CheckKey(KeyCode key, Action action)
        {
            if (Input.GetKeyDown(key))
            {
                action?.Invoke();
            }
        }
    }
}
