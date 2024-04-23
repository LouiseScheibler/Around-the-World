using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PieceController : MonoBehaviour
{
    public GameObject[] pieces = new GameObject[24];
    public GameObject painelQuest;

    // Start is called before the first frame update
    void Start()
    {
        if (pieces.Length -1 == 23 && PiceseScript.instance.InRightPosition) ;
        {
            painelQuest.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
