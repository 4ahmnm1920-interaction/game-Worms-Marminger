﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormsController : MonoBehaviour
{

    public Rigidbody rb;
    public Rigidbody projectile;
    public float ammospeed;
    public float jumpforce;
    public float moveRight;
    public float moveLeft;
    public Transform Spawnpoint;

   


    public KeyCode ShootKey;
    public KeyCode JumpKey;
    public KeyCode RightKey;
    public KeyCode LeftKey;



    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(JumpKey))
        {
        
            Vector3 force = new Vector3(0,jumpforce,0);
            rb.AddForce(force);
            //Debug.Log("Taste ist gedrückt!");

        }

        if (Input.GetKey(RightKey))
        {

            Vector3 For = new Vector3(moveRight, 0, 0);
            rb.AddForce(For);
            Debug.Log("RightKey ist gedrückt!");
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if (Input.GetKey(LeftKey))
        {

            Vector3 Back = new Vector3(- moveLeft, 0, 0);
            rb.AddForce(Back);
            Debug.Log("LeftKey ist gedrückt!");
            transform.eulerAngles = new Vector3(0, 180, 0);

        }


        if (Input.GetKeyDown(ShootKey))
        {
            Rigidbody clone;
            clone = Instantiate(projectile, Spawnpoint.position, transform.rotation);
            Vector3 kraft = this.transform.right * ammospeed;
            clone.AddForce(kraft);
        }

        
        
    }
}
