using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour
{
    public delegate void OnMoveDel(Vector2 direction); //�븮��
    public OnMoveDel OnMoveEvent;

    public event Action<Vector2> OnLookEvent; //�Ʒ��� ����(�����ϰԳ�Ÿ��)
    //public delegate void OnLookDel(Vector2 direction);
    //public OnLookDel OnLookEvent;

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
