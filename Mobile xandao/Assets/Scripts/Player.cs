using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       /* 
        * if (Input.GetMouseButtonDown(0))
        {

        } 
       */
        if (Input.GetButtonDown("Fire1"))
        {
            body.gravityScale *= -1; 
        }
    }
}
