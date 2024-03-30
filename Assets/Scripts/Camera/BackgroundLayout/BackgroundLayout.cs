using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLayout : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Vector2 _multiplier;

    private Vector3 _startPos;

    private void Awake()
    {
        _startPos = transform.localPosition;
    }

    private void Update()
    {
        var input = new Vector3(_camera.transform.position.x * _multiplier.x, _camera.transform.position.y * _multiplier.y, 0);
        var pos = _startPos - input;
        pos.z = 0;
        transform.localPosition = pos;
    }
}
