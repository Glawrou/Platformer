using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NoseAA.InputObservers;
using NoseAA;

public class Player : MonoBehaviour
{
    [SerializeField] private InputObserver _inputObserver;
    [SerializeField] private PlayerAnimation _playerAnimation;
    [SerializeField] private PlayerMove _playerMove;

    private void Start()
    {
        _inputObserver.OnMove += InputMoveHandler;
        _inputObserver.OnJump += InputJumpHandler;
    }

    public void InputMoveHandler(Vector2 move)
    {
        _playerAnimation.SetRun(move != Vector2.zero);
        _playerAnimation.SetFlip(move.x);
    }

    public void InputJumpHandler()
    {
        
    }
}