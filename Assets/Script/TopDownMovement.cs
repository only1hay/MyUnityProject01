using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    //public float speed = 5f; //�ʹ� ������ ������ ���ǵ尪�� �־��ش�.
    //private SpriteRenderer spriteRenderer;


    //Start is called before the first frame update
    //void Start()
    //{
    //    spriteRenderer = GetComponent<SpriteRenderer>();
    //}

    //Update is called once per frame
    //void Update()
    //{
    //    //�� �����Ӹ��� ����Ǳ� ������ update�� �־� �ش�.
    //    //InputManager���� �� �κ��� �����´�.
    //    float x = Input.GetAxisRaw("Horizontal");
    //    float y = Input.GetAxisRaw("Vertical");

    //    //x,y���� �־ z�� 0���� ó���� �ȴ�.
    //    transform.position += (new Vector3(x, y)).normalized * Time.deltaTime * speed;
    //    // (new Vector3(x, y)).normalized-> ������ ���� ������ 1�� �ǰ�(�밢���� �ӵ���) , Time.deltaTime -> ������ ����

    //    Vector3 mousePos = Input.mousePosition; //���콺���� Vector3�� �޾ƾ� ��.

    //    Debug.Log(mousePos);

    //    if (mousePos.x > Screen.width / 2)//��ũ���� ������ ���� �߽����� �����ʿ� ������
    //    {
    //        spriteRenderer.flipX = false;
    //    }
    //    else if (mousePos.x < Screen.width / 2)
    //    {
    //        spriteRenderer.flipX = true; //spriteRenderer�� flipX���� üũ�Ǿ������� ĳ���Ͱ� �ݴ������ �ٶ󺻴�.->����Ƽ UI���� Ȯ�� ����
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

    private void FixedUpdate()//������Ģ ���� ����� �� Update��� FixedUpdate�� �־��ش�.
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
