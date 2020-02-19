using System.Collections;
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

   


    public KeyCode ShootKey;
    public KeyCode ShootKey2;
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
            Debug.Log("Taste ist gedrückt!");

        }

        if (Input.GetKey(RightKey))
        {

            Vector3 For = new Vector3(moveRight, 0, 0);

            rb.AddForce(For);
            Debug.Log("Taste ist gedrückt!");
        }

        if (Input.GetKey(LeftKey))
        {

            Vector3 Back = new Vector3(- moveLeft, 0, 0);

            rb.AddForce(Back);
            Debug.Log("Taste ist gedrückt!");
        }


        if (Input.GetKeyDown(ShootKey))
        {
            Rigidbody clone;
            Vector3 Shoot = new Vector3(0.5f, 0.5f, 0f);
            clone = Instantiate(projectile, transform.position + Shoot, transform.rotation);
            clone.velocity = transform.TransformDirection(ammospeed, 0, 0);
            Vector3 kraft = new Vector3(ammospeed, 0, 0);
            rb.AddForce(kraft);
        }

        if (Input.GetKeyDown(ShootKey2))
        {
            Rigidbody clone;
            Vector3 Shoot = new Vector3(0.5f, 0.5f, 0f);
            clone = Instantiate(projectile, transform.position + Shoot, transform.rotation);
            clone.velocity = transform.TransformDirection(ammospeed, 0, 0);
            Vector3 kraft = new Vector3(ammospeed, 0, 0);
            rb.AddForce(kraft);
        }


    }
}
