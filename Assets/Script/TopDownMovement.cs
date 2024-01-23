using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    //public float speed = 5f; //너무 느리기 때문에 스피드값을 넣어준다.
    //private SpriteRenderer spriteRenderer;


    //Start is called before the first frame update
    //void Start()
    //{
    //    spriteRenderer = GetComponent<SpriteRenderer>();
    //}

    //Update is called once per frame
    //void Update()
    //{
    //    //매 프레임마다 실행되기 때문에 update에 넣어 준다.
    //    //InputManager에서 쓸 부분을 가져온다.
    //    float x = Input.GetAxisRaw("Horizontal");
    //    float y = Input.GetAxisRaw("Vertical");

    //    //x,y값만 넣어도 z는 0으로 처리가 된다.
    //    transform.position += (new Vector3(x, y)).normalized * Time.deltaTime * speed;
    //    // (new Vector3(x, y)).normalized-> 벡터의 값이 무조건 1이 되게(대각선의 속도가) , Time.deltaTime -> 프레임 고정

    //    Vector3 mousePos = Input.mousePosition; //마우스값도 Vector3로 받아야 함.

    //    Debug.Log(mousePos);

    //    if (mousePos.x > Screen.width / 2)//스크린의 가로의 반을 중심으로 오른쪽에 있으면
    //    {
    //        spriteRenderer.flipX = false;
    //    }
    //    else if (mousePos.x < Screen.width / 2)
    //    {
    //        spriteRenderer.flipX = true; //spriteRenderer의 flipX값이 체크되어있으면 캐릭터가 반대방향을 바라본다.->유니티 UI에서 확인 가능
    //    }

    //}

    private TopDownCharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()//물리법칙 등을 사용할 때 Update대신 FixedUpdate에 넣어준다.
    {
        ApplyMovement(_movementDirection);
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction *= 5;

        _rigidbody2D.velocity = direction;
    }


}
