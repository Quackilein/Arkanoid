using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class StoreValueManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static StoreValueManager Instance;
    public string currentUser; // new variable declared
    public string highscoreUser; // new variable declared
    public int highscore = 0; // new variable declared

    private void Awake()
    {
        LoadHighscoreData();

        if (Instance == null)
        {
            Instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }

    void LoadHighscoreData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        Debug.Log(path);
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            highscore = data.highScore;
            highscoreUser = data.username;
            GameObject.Find("Highscore").GetComponent<TMPro.TextMeshProUGUI>().text = "Best Score: " + highscoreUser + ": " + highscore;
        }
    }

    [System.Serializable]
    class SaveData
    {
        public string username;
        public int highScore;
    }


}
