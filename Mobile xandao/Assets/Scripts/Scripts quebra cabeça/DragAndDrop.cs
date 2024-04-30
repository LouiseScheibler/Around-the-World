using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public static DragAndDrop instance;
    public GameObject SelectedPiece;

    private void Start()
    {
        instance = this;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print($"foi Input.GetMouseButtonDown(0)");
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.transform.CompareTag("Puzzle"))
            {
                print($"foi CompareTag(Puzzle)");
                if (!hit.transform.GetComponent<PiceseScript>().InRightPosition)
                {
                    print($"is in rightPosition");
                    SelectedPiece = hit.transform.gameObject;
                    SelectedPiece.GetComponent<PiceseScript>().Selected = true;
                    print($"{SelectedPiece}");
                }
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            print($"GetMouseButtonUp(0)");
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            SelectedPiece.GetComponent<PiceseScript>().Selected = false;
            SelectedPiece = null;
        }
        
        if (SelectedPiece != null)
        {
            print($"selected != null");
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SelectedPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
        }

    }
}
