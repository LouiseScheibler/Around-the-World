using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        gameObject.AddComponent<Rigidbody2D>();
    }
    private void OnMouseEnter()
    {
        GetComponent<SpriteRenderer>().color = Color.cyan;
    }
    private void OnMouseExit()
    {
        Destroy(gameObject.GetComponent<Rigidbody2D>());
        GetComponent<SpriteRenderer>().color = Color.gray;
    }
    private void OnMouseDrag()

    {
        //gameObject.SetActive(false);
        GetComponent<SpriteRenderer>().enabled = false; 
    }
    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().enabled = true;
    }
}
