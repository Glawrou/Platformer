using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChest : PlayerTrigger
{
    [SerializeField] public Animator _animator;
    [SerializeField] public GameObject _content;

    private const string AnimTrigger = "IsOpen";

    public void Open()
    {
        _animator.SetBool(AnimTrigger, true);
    }

    public void Spawn()
    {
        var content = Instantiate(_content, transform.position, Quaternion.identity, null);
        Destroy(content, 1f);
        _animator.SetBool(AnimTrigger, false);
    }

    private void Awake()
    {
        OnPlayerEnter += EnterHandler;
    }

    private void EnterHandler(Player player)
    {
        Open();
    }
}
