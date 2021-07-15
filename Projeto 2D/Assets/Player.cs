using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : AliveEntity
{
    private Vector2 moveDirection;

    private Rigidbody2D rig;

    [SerializeField]private float moveSpeed = 4f ;

    void Start()
    {
        getComponents();
        
    }

    void FixedUpdate()
    {
        processInputs();
        move();
    }

    void getComponents(){
        rig = GetComponent<Rigidbody2D>();
    }

    void processInputs(){
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX,moveY).normalized;

    }

    void move(){
        rig.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    
}
