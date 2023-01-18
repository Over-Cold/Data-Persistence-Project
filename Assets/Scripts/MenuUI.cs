using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUI : MonoBehaviour
{
    public TMP_InputField playerName;
    public Text bestScoreText;

    // Start is called before the first frame update
    void Start()
    {
        bestScoreConfig(DataManager.Instance.bestScore);
        playerName.text = DataManager.Instance.playerName;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void bestScoreConfig(int bestScore)
    {
        bestScoreText.text = "BestScore: " + DataManager.Instance.bestScoreName + ": " + bestScore;
    }

    public void SaveName()
    {
            DataManager.Instance.playerName = playerName.text.ToString();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
        DataManager.Instance.saveData();
    }
}