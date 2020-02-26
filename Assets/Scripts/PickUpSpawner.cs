using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSpawner : MonoBehaviour
{
    public int iterations;
    public GameObject PickUp;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < iterations; i++)
        {
            //PickUps werden gecloned
            float x = Random.Range(-1f, 5f);
            float y = Random.Range(35f, 37f);
            float z = 0f;
            Vector3 position = new Vector3(x,y,z);

            GameObject clone;
            clone = Instantiate(PickUp, position, Quaternion.identity);
            Debug.Log("Wird ausgeführt");


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
