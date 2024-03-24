using UnityEngine;

namespace NoseAA.InputObservers
{
    public class PCInputObservers : InputObserver
    {
        private void Update()
        {
            var move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            OnMove?.Invoke(move);

            if (Input.GetButtonDown("Jump"))
            {
                OnJump?.Invoke();
            }
        }
    }
}
