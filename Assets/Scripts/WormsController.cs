using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormsController : MonoBehaviour
{

    public Rigidbody rb;
    public float jumpforce;
    public float moveForward;
    public float moveBackward;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
        
            Vector3 force = new Vector3(0,jumpforce,0);

            rb.AddForce(force);
            Debug.Log("Taste ist gedrückt!");
        }

        if (Input.GetKey(KeyCode.D))
        {

            Vector3 For = new Vector3(moveForward, 0, 0);

            rb.AddForce(For);
            Debug.Log("Taste ist gedrückt!");
        }

        if (Input.GetKey(KeyCode.A))
        {

            Vector3 Back = new Vector3(0, 0, moveBackward);

            rb.AddForce(Back);
            Debug.Log("Taste ist gedrückt!");
        }

    }
}
