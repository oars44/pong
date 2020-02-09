using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power : MonoBehaviour
{

    public bool speed = false;
    public int num;

    // Start is called before the first frame update
    void Start()
    {
        if (speed)
        {
            num = 0;
        }
        else
        {
            num = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        Destroy(gameObject);
    }
}
