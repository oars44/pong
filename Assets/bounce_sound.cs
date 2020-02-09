using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce_sound : MonoBehaviour
{
    public AudioClip bounce;
    public AudioClip goal;

    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "paddles")
        {
            source.PlayOneShot(bounce, 1f);
        }

        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "goals")
        {
        source.PlayOneShot(goal, 1f);
        }
    }
}
