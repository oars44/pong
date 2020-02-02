using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle_control : MonoBehaviour
{
    public bool paddle_a;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (paddle_a)
        { 
            transform.Translate(0f, 0f, Input.GetAxis("Vertical") * speed * Time.deltaTime);
         
            if (transform.position.z > 5.5)
            {
                transform.position = new Vector3(-10f, .5f, 5f);
            }

            if (transform.position.z < -5.5)
            {
                transform.position = new Vector3(-10f, .5f, -5f);
            }
        }
        else
        {

            transform.Translate(0f, 0f, Input.GetAxis("player2") * speed * Time.deltaTime);

            if (transform.position.z > 5.5)
            {
                transform.position = new Vector3(10f, .5f, 5f);
            }

            if (transform.position.z < -5.5)
            {
                transform.position = new Vector3(10f, .5f, -5f);
            }
        }
    }
}
