using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power_control : MonoBehaviour
{
    public GameObject speed;
    public GameObject dupe;

    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            spawn(1);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            spawn(2);
        }
    }

   private void spawn(int num)
    {
        float dirx = Random.Range(-8, 8);
        float dirz = Random.Range(-6, 6);
        GameObject power;

        if (num == 1)
        {
            power = speed;
        }
        else
        {
            power = dupe;
        }

        Instantiate(power, new Vector3(dirx, 0, dirz), Quaternion.identity);
      
    }
}
