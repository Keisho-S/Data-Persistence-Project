using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class RecordManagement : MonoBehaviour
{
    public static RecordManagement Instance;
    //private StartMenu startMenu;
    public InputField playerName;
    public TextMeshProUGUI dataText;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dataText.text = "New Record: " + ScoreManager.score + "\nPlayer: " + ScoreManager.playerName + "\n";
        ScoreManager.playerName = playerName.text;
        
    }

    /*new code: singleton pattern*/
    private void Awake()
    {
        //if (Instance != null)
        //{
        //    Destroy(gameObject);
        //    return;
        //}

        //Instance = this;
        
        //DontDestroyOnLoad(Instance);             
        dataText.text = "New Record\n" + ScoreManager.score;
     
    }

    
    public void BackToMenu()
    {
        ScoreManager.scoreManager.SavePlayer1Data();
        ScoreManager.scoreManager.SavePlayer1ScoreData();
        SceneManager.LoadScene(1);
    }
}
