using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PieceController : MonoBehaviour
{
    public static PieceController instance;
    public List<GameObject> pieces = new List<GameObject>();
    public GameObject painelQuest;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(pieces.Count == 24)
        {
            painelQuest.SetActive(true);
        }
    }
}
