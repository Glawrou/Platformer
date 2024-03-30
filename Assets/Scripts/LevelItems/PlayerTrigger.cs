using System;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    public event Action<Player> OnPlayerEnter;
    public event Action<Player> OnPlayerExit;

    protected Player _currentPlayer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = GetPlayer(collision);
        if (!player)
        {
            return;
        }

        _currentPlayer = player;
        OnPlayerEnter?.Invoke(player);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        var player = GetPlayer(collision);
        if (!player)
        {
            return;
        }

        _currentPlayer = null;
        OnPlayerExit?.Invoke(player);
    }

    private Player GetPlayer(Collider2D collider)
    {
        return collider.GetComponent<Player>();
    }
}
