using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_control : MonoBehaviour
{
    public GameObject ball;
    public float start_speed = 10f;
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        float x = transform.position.x;
        float z = transform.position.z;

        launch(x, z);
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.position.x > 13) ^ (transform.position.x < -13))
        {
            launch(0, 0);
        }
    }

    private void launch(float x, float z)
    {

        transform.position = new Vector3(x, .5f, z);
        speed = start_speed;

        float dirx = Random.Range(0, 2);
        if (dirx == 0)
        {
            dirx = -1;
        }

        float diry = Random.Range(0, 2);
        if (diry == 0)
        {
            diry = -1;
        }

        GetComponent<Rigidbody>().velocity = new Vector3(speed * dirx, 0f, speed * diry);
    }

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "paddles")
        {
            GetComponent<Rigidbody>().velocity *= 1.5f;
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "power")
        {
            power pow = col.gameObject.GetComponent<power>();

            if (pow.num == 0)
            {
                GetComponent<Rigidbody>().velocity *= 2f;
            }
            else
            {
                float x = transform.position.x;
                float z = transform.position.z;

                launch(x, z);
                Instantiate(ball, new Vector3(x, 0, z), Quaternion.identity);
            }
        }
    }
}
