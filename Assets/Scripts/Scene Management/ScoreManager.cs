using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;
using System.IO;
public class ScoreManager : MonoBehaviour
{
    
    public static int score;
    public static string playerName;
    // Start is called before the first frame update
    public static ScoreManager scoreManager;
    private void Awake()
    {
        if (scoreManager != null)
        {
            Destroy(gameObject);
            return;
        }

        scoreManager = this;
        DontDestroyOnLoad(scoreManager);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    /*new code: JSON part, save player name and score*/
    [System.Serializable]
    class SaveData
    {
        public string playerName;
        public int score;
    }

    public void SavePlayer1Data()
    {
        SaveData player1Data = new SaveData();
        player1Data.playerName = playerName;
        //player1Data.score = score;
        string json = JsonUtility.ToJson(player1Data);

        File.WriteAllText(Application.persistentDataPath + "/savePlayer1Name.json", json);
    }

    public string LoadPlayer1Data()
    {
        string path = Application.persistentDataPath + "/savePlayer1Name.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData player1Data = JsonUtility.FromJson<SaveData>(json);
            playerName = player1Data.playerName;
            //score = player1Data.score;

            //startMenu.topPlayerText.text = dataText.text;
        }
        return playerName;
    }

    public void SavePlayer1ScoreData()
    {
        SaveData player1Data = new SaveData();
        //player1Data.playerName = playerName.text;
        player1Data.score = score;
        //player1Data.score = 0;
        string json = JsonUtility.ToJson(player1Data);

        File.WriteAllText(Application.persistentDataPath + "/savePlayer1Score.json", json);
    }

    public int LoadPlayer1ScoreData()
    {
        string path = Application.persistentDataPath + "/savePlayer1Score.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData player1Data = JsonUtility.FromJson<SaveData>(json);
            //playerName.text = player1Data.playerName;
            score = player1Data.score;
            //dataText.text = "New Record \n" + score + " Player: " + playerName.text + "\n";
            //startMenu.topPlayerText.text = dataText.text;
        }
        return score;
    }

}

