using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_control : MonoBehaviour
{
    public float start_speed = 10f;
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        launch();
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.position.x > 13) ^ (transform.position.x < -13))
        {
            launch();
        }
    }

    private void launch()
    {

        transform.position = new Vector3(0f, .5f, 0f);
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
}
