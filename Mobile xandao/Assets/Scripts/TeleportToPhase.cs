using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportToPhase : MonoBehaviour
{
    public string phaseName;

    public void PlayPhase()
    {
        SceneManager.LoadScene(phaseName);
    }
}
