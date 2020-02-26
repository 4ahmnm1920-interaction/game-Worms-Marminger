using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{

    public WormsController worm;
    public float speed;

    void OnCollisionEnter(Collision collision)
    {

        //Kollisionsabfrage
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log ("Collide");

            //Zugriff auf WormsController- Neue Variable wird zugewiesen- Neue Variable wird einen Wert zugewiesen
            worm = collision.gameObject.GetComponent<WormsController>();
            worm.ammospeed = speed;


            //Gravity wird deaktiviert
            /* worm.rb.useGravity = false; */

            Destroy (this.gameObject);
        }

        

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
