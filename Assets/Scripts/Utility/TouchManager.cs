﻿using UnityEngine;
using System.Collections;

/// <summary>
/// シングルタッチしか対応していません
/// </summary>
public class TouchManager : MonoBehaviour
{

    public static bool _isPush { get; private set; }
    public static bool _isPull { get; private set; }
    public static bool _isMove { get; private set; }

    /// <summary>
    /// タッチしたときの処理
    /// </summary>
    /// <returns></returns>
    public static bool TouchBegin()
    {
        if (Application.platform == RuntimePlatform.Android
            || Application.platform == RuntimePlatform.IPhonePlayer)
        {
           return Input.touches[0].phase == TouchPhase.Began;
        }

        return Input.GetMouseButtonDown(0);
    }
    /// <summary>
    /// タッチしている間の処理
    /// </summary>
    /// <returns></returns>
    public static bool TouchMove()
    {
        if(Application.platform == RuntimePlatform.Android
            || Application.platform == RuntimePlatform.IPhonePlayer)
        {
            return Input.touches[0].phase == TouchPhase.Moved
                || Input.touches[0].phase == TouchPhase.Stationary;
        }

        return Input.GetMouseButton(0);
    }

    /// <summary>
    /// タッチし終えたとき
    /// </summary>
    /// <returns></returns>
    public static bool TouchEnded()
    {
        if(Application.platform == RuntimePlatform.Android
            || Application.platform == RuntimePlatform.IPhonePlayer)
        {
            return Input.touches[0].phase == TouchPhase.Ended;
        }

        return Input.GetMouseButtonUp(0);
    }

    /// <summary>
    /// タッチの座標を返す(スクリーン座標)
    /// </summary>
    /// <returns></returns>
    public static Vector2 TouchPosition()
    {
        if (Application.platform == RuntimePlatform.Android
            || Application.platform == RuntimePlatform.IPhonePlayer)
        {
            return Input.touches[0].position;
        }

        return Input.touches[0].position;
    }
}
