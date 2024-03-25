using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMove : MonoBehaviour
{
    public event Action<bool> OnSitChange;

    [SerializeField] private CharacterController2D _controller2D;
    [SerializeField] private float _speed = 1;

    private float _moveX;
    private bool _isJump;
    private bool _isSit;

    public void Move(float moveX)
    {
        _moveX = moveX;
    }

    public void Jump()
    {
        _isJump = true;
        SetSit(false);
    }

    public void Sit()
    {
        SetSit(!_isSit);
    }

    private void Update()
    {
        _controller2D.Move(_moveX * _speed * Time.fixedDeltaTime, _isSit, _isJump);
        _isJump = false;
    }

    private void SetSit(bool value)
    {
        _isSit = value;
        OnSitChange?.Invoke(_isSit);
    }
}
