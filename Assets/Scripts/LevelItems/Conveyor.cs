using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour
{
    [SerializeField] private PlayerTrigger _leftTrigger;
    [SerializeField] private PlayerTrigger _rightTrigger;
    [SerializeField] private SurfaceEffector2D _surface;
    [SerializeField] private float _speed;

    private void Start()
    {
        _leftTrigger.OnPlayerEnter += LeftTriggerHandler;
        _rightTrigger.OnPlayerEnter += RightTriggerHandler;
    }

    public void LeftTriggerHandler(Player player)
    {
        _surface.speed = _speed;
    }

    public void RightTriggerHandler(Player player)
    {
        _surface.speed = -_speed;
    }
}
