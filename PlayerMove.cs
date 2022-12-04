using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //Выбор в "Инспекторе" какие слои будут землёй
    public LayerMask whatIsGround;
    //Проверка касания земли
    public Transform groundCheck;
    //Если газовик находится на земле
    public bool isGrounded;
    //Значение величины силы прыжка
    public float jumpForce;
    //Переменная для скорости движения персонажа
    public float speed;
    //Ссылка на компонент Unity Rigitbody 2D(Переменная)
    Rigidbody2D rb;
    public bool isLookingLeft;

    void Start()
    {
        //Сама ссылка на компонент, Unity RigitBody 2D
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetButtonDown("Jump")&& isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;

        }
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapPoint(groundCheck.position, whatIsGround);
        //Горизонтальная ось
        float x = Input.GetAxis("Horizontal");
        Vector3 move = new Vector3(x * speed, rb.velocity.y, 0f);
        //Изменение скорости игрока
        rb.velocity = move;
        if (x < 0 && isLookingLeft)
            TurnTheGazovic_0();
   }

  
    void TurnTheGazovic_0()
{
    isLookingLeft = !isLookingLeft;
    transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
}
}

    
        

    