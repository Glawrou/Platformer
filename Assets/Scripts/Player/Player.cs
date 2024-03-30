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
        _inputObserver.OnAttack += InputAttackHandler;
        _inputObserver.OnSit += InputSitHandler;
    }

    public void SetWaterState(bool isWater) => _playerMove.SetWater(isWater);

    private void InputMoveHandler(Vector2 move)
    {
        _playerAnimation.SetRun(move != Vector2.zero);
        _playerMove.Move(move.x);
    }

    private void InputJumpHandler()
    {
        _playerMove.Jump();
    }

    private void InputAttackHandler()
    {
        _playerAnimation.Attack();
    }

    private void InputSitHandler()
    {
        _playerMove.Sit();
    }
}
