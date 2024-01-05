using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Data;
using UnityEngine.SocialPlatforms.Impl;

public class StartMenu : MonoBehaviour
{
    public TextMeshProUGUI topPlayerText;

    // Start is called before the first frame update
    void Start()
    {
        TopList();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TopList()
    {

        if (ScoreManager.scoreManager != null)
        {
            topPlayerText.text = "Top Player: " + ScoreManager.scoreManager.LoadPlayer1Data() + "\nScore: " + ScoreManager.scoreManager.LoadPlayer1ScoreData();
        }
        
    }


    public void LoadScene()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
#if !UNITY_EDITOR
        Application.Quit();
#else
        EditorApplication.ExitPlaymode();
#endif
    }

    
}
