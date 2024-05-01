using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject creditsPainel, controlsPainel, levelsPainel;

    public void PlayBTN()
    {
        levelsPainel.SetActive(true);
        //SceneManager.LoadScene("scene");
    }
    public void ReturnMenu()
    {
        levelsPainel.SetActive(false);
    }

    public void OpenCreditsPainel()
    {
        creditsPainel.SetActive(true);
    }
    public void CloseCreditsPainel()
    {
        creditsPainel.SetActive(false);
    }
    public void OpenControlsPainel()
    {
        controlsPainel.SetActive(true);
    }
    public void CloseControlsPainel()
    {
        controlsPainel.SetActive(false);
    }

    public void QuitBTN()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}