using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiceseScript : MonoBehaviour

{
    private Vector3 RightPosition;
    public bool InRightPosition;
    public bool Selected;
    void Start()
    {
        RightPosition = transform.position;
        transform.position = new Vector3(Random.Range(2f, 8f), Random.Range(2.5f, -5));
    }


    void Update()
    {
        if (Vector3.Distance(transform.position, RightPosition) < 0.2f)
        {
            if (!Selected)
            {

            transform.position = RightPosition;
            InRightPosition = true; 

            }

        }
    }
}
