using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text scoreText;
    private int DIAMENTY;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        DIAMENTY = 0;
        UpdateScoreText();
    }

    public void AddScore(int amount)
    {
        DIAMENTY += amount;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "DIAMENTY: " + DIAMENTY + "/30";
    }
}
