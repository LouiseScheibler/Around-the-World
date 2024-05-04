using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TeleportToPhase : MonoBehaviour
{
    public Button[] bot�es;

    private void Update()
    {
        for (int i = 0; i < bot�es.Length; i++)
        {
            if (i+1>PlayerPrefs.GetInt("faseCompleta"))
            {
                bot�es[i].interactable = false;
            }
            
        }
    }


    public void PlayPhase(string tp)
    {
        SceneManager.LoadScene(tp);
    }
}
