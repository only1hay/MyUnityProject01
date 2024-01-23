using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    public void OnMove(InputValue Value)
    {
        Vector2 moveinput = Value.Get<Vector2>();
        Debug.Log(moveinput);
        CallMoveEvent(moveinput);
    }

    public void OnLook(InputValue Value)
    {
        Vector2 newAim = Value.Get<Vector2>();
        //���彺ũ���� ��ǥ���� ī�޶� ������ �ִ�.
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(newAim);

        newAim = (worldPos - (Vector2)transform.position).normalized;
        //�÷��̾ ���� ���� ���콺��ǥ
        CallLookEvent(newAim);
    }

}
