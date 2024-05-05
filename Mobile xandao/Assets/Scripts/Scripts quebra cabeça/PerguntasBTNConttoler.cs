using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PerguntasBTNConttoler : MonoBehaviour
{
    public static PerguntasBTNConttoler Instance;
    public string nextLevel;
    public GameObject congratsPainel;
    public List<GameObject> wrongBtnList = new List<GameObject>();
    public string actualScene;

    private void Start()
    {
        Instance = this;
    }
    private void Update()
    {
        if(wrongBtnList.Count >= 2)
        {
            SceneManager.LoadScene(actualScene);
        }
        
    }
    public void BTNCerto()
    {
        if (SceneManager.GetActiveScene().buildIndex > PlayerPrefs.GetInt("faseCompleta"))
        {
            PlayerPrefs.SetInt("faseCompleta", SceneManager.GetActiveScene().buildIndex);
            PlayerPrefs.Save();
            
        }
        SceneManager.LoadScene(nextLevel);

    }

    public void BTNErrado()
    {
        if (!WrongBTN.instance.isDisable)
        {
            WrongBTN.instance.isDisable = true;
            wrongBtnList.Add(WrongBTN.instance.button);
        }
    }
    public void BTNLastQuestionCorect()
    {
        congratsPainel.SetActive(true);
    }
}