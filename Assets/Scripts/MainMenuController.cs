using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainMenuController : MonoBehaviour
{
    public TMP_InputField inputName;
    public Button startButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartGame()
    {
        string v = inputName.text;
        if (string.IsNullOrWhiteSpace(v)== false)
        SceneManager.LoadScene("main");
        else
        {
            //todo add some logic to show message at some point.
        }
    }

    /// <summary>
    /// This is called from the user name input on change.
    /// </summary>
    public void SetPlayerName()
    {
       
            GameManager.instance.playerName = inputName.text;      
    }

    public void Exit()
    {
 
        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #else
        Application.Quit();
        #endif

    }

    public void BestScores()
    {
        SceneManager.LoadScene("BestScores");
    }
}
