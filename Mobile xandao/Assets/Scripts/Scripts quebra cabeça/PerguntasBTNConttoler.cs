using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PerguntasBTNConttoler : MonoBehaviour
{

    public string nextLevel;
    public GameObject congratsPainel;

    public void BTNCerto()
    {
        SceneManager.LoadScene(nextLevel);
    }

    public void BTNErrado()
    {

    }
    public void BTNLastQuestionCorect()
    {
        congratsPainel.SetActive(true);
    }
}