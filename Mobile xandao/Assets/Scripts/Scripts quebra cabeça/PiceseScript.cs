using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PiceseScript : MonoBehaviour
{
    public static PiceseScript instance;
    private Vector3 RightPosition;
    public bool InRightPosition;
    public bool Selected;
    public GameObject panel;
    public static int pieces;

    void Start()
    {
        instance = this;
        RightPosition = transform.position;
        transform.position = new Vector3(Random.Range(3f, 8f), Random.Range(2.5f, -5));
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
            /*if (InRightPosition)
            {
                pieces++;
                InRightPosition = false;
            }*/
        }
        /*if(pieces >= 24)
        {
            panel.SetActive(true);
        }*/
    }
       
}
