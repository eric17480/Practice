using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public GameObject nextLevelUI;
    private int score = 0;

    void Start()
    {
        UpdateScoreUI();
        nextLevelUI.SetActive(false); // 初始隱藏下一關的UI
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScoreUI();
        
        if (score >= 5)
        {
            ShowNextLevelUI();
        }
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    void ShowNextLevelUI()
    {
        nextLevelUI.SetActive(true); // 顯示下一關的UI
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene("NextLevelSceneName"); // 替換為下一關的場景名稱
    }
}
