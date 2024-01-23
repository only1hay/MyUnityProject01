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
        //월드스크린의 좌표값은 카메라가 가지고 있다.
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(newAim);

        newAim = (worldPos - (Vector2)transform.position).normalized;
        //플레이어에 대한 로컬 마우스좌표
        CallLookEvent(newAim);
    }

}
