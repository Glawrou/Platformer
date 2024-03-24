using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NoseAA;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private const string AnimTriggerIsRun = "IsRun";
    private const string AnimTriggerIsJump = "IsJump";
    private const string AnimTriggerDeath = "Death";

    public void SetFlip(float moveX)
    {
        if (moveX == 0)
        {
            return;
        }

        _spriteRenderer.flipX = moveX < 0;
    }

    public void SetRun(bool isRun)
    {
        _animator.SetBool(AnimTriggerIsRun, isRun);
    }

    public void SetJump(bool isJump)
    {
        _animator.SetBool(AnimTriggerIsJump, isJump);
    }

    private void Death()
    {
        _animator.SetTrigger(AnimTriggerDeath);
    }
}
