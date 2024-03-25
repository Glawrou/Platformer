using System;
using UnityEngine;

namespace NoseAA.InputObservers
{
    public class PCInputObservers : InputObserver
    {
        [SerializeField] private KeyCode _sitCode;

        private void Update()
        {
            var move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            OnMove?.Invoke(move);

            CheckButton("Jump", OnJump);
            CheckButton("Fire1", OnAttack);
            CheckButton("Cancel", OnCancel);
            CheckKey(_sitCode, OnSit);
        }
    }
}
