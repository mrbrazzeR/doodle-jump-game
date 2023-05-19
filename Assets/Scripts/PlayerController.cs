using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigid;

    [SerializeField] private float speed;
    // Start is called before the first frame update

    private void FixedUpdate()
    {
        if (GameStatus.Instance.GameState == GameState.StartJump)
        {
            var x = Input.GetAxisRaw("Horizontal") * speed;
            var vector2 = rigid.velocity;
            vector2.x = x;
            rigid.velocity = vector2;
        }

        if (GameStatus.Instance.GameState == GameState.StartFlappy)
        {
            rigid.gravityScale =20;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }
        }
    }

    private void Jump()
    {
        rigid.velocity=Vector2.up*500;
    }
}