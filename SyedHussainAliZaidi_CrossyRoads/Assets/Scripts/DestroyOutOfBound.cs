using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    public float boundary = 80;
    // Start is called before the first frame update
    void Start()
    {
        boundary = 80;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -boundary) 
        {
            Destroy(gameObject);
        }
        if (transform.position.x > boundary)
        {
            Destroy(gameObject);
        }


    }
}
