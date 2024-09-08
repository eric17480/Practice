using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    /// <summary>成績文字</summary>
    [Header("成績顯示")]
    public TMP_Text scoreText;
    public GameObject nextLevelUI;

    #region 分數
    /// <summary>
    /// 成績計數
    /// </summary>
    [SerializeField]
    private int scoreCount = 0;
    /// <summary>
    /// 每次得分獲得的分數
    /// </summary>
    private const int ADD_SCORE = 5;
    /// <summary>
    /// 通關所需分數
    /// </summary>
    private const int PASS_SCORE = 30;
    #endregion

    void Start()
    {
        Init();
        UpdateScoreUI();
    }

    /// <summary>
    /// 初始化
    /// </summary>
    void Init()
    {
        scoreCount = 0;
        SetSceneUI(false);
    }

    public void AddScore()
    {
        scoreCount += ADD_SCORE;
        UpdateScoreUI();
        SetSceneUI(scoreCount >= PASS_SCORE);
    }

    void UpdateScoreUI()
    {
        //if (scoreText != null) 
        //    scoreText.text = "Score: " + score.ToString();   
        if (scoreText == null)
            Debug.Log(scoreText + " 不見了");
        else
        {
            scoreText.text = scoreCount.ToString();
            Debug.Log("分數增加,當前分數= " + scoreCount);
        }
    }

    /// <summary>
    /// 設定場景UI是否顯示
    /// </summary>
    /// <param name="isShow"></param>
    void SetSceneUI(bool isShow)
    {
        nextLevelUI.SetActive(isShow);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene("NextLevelSceneName"); // 替換為下一關的場景名稱
    }
}
