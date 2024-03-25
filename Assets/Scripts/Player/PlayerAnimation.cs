using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NoseAA;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private CharacterController2D _controller2D;
    [SerializeField] private PlayerMove _playerMove;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private const string AnimTriggerIsRun = "IsRun";
    private const string AnimTriggerIsJump = "IsJump";
    private const string AnimTriggerSit = "IsSit";
    private const string AnimTriggerDeath = "Death";
    private const string AnimTriggerAttack = "Attack";

    private void Start()
    {
        _controller2D.OnChangeGround += (value) => SetJump(!value);
        _playerMove.OnSitChange += SetSit;
    }

    public void SetRun(bool isRun)
    {
        _animator.SetBool(AnimTriggerIsRun, isRun);
    }

    public void SetJump(bool isJump)
    {
        _animator.SetBool(AnimTriggerIsJump, isJump);
    }

    public void SetSit(bool isSit)
    {
        _animator.SetBool(AnimTriggerSit, isSit);
    }

    public void Attack()
    {
        _animator.SetTrigger(AnimTriggerAttack);
    }

    private void Death()
    {
        _animator.SetTrigger(AnimTriggerDeath);
    }
}
