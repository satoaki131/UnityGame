using UnityEngine;
using System.Collections;
using System;

public class TitleFontMove : MonoBehaviour {

    private float _sinMoveCount = 0;

    [SerializeField]
    private float _speed = 2.0f;
    [SerializeField]
    private float _moveY = 1.0f;

    void Update()
    {
        _sinMoveCount += Time.deltaTime * _speed;

        transform.Translate(Vector3.up * Mathf.Sin(_sinMoveCount) * _moveY);

    }

}
