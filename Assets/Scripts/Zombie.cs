﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public bool canMove;
    public bool death;
    Animator anim;
    BoxCollider2D col;

    public float speed;
    void Start()
    {
        canMove = true;
        anim = GetComponent<Animator>(); 
        col = GetComponent<BoxCollider2D>();
    }

    void Update()
    {

        if (death)
        {
            col.enabled = false;
            anim.SetTrigger("Death");

            if (this.anim.GetCurrentAnimatorStateInfo(0).IsName("Zombie_Death"))
            {
                Destroy(gameObject, 1f);
                death = false;
            }

            canMove = false;

        }
        if (canMove)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

    }

}
