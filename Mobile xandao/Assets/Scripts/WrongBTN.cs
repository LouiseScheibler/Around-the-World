using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WrongBTN : MonoBehaviour
{
    public static WrongBTN instance;
    public GameObject button;
    public bool isDisable;
    
    private void Start()
    {
        instance = this;
    }
}