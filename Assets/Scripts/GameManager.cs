using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    [SerializeField] GameObject score;
    [SerializeField] GameObject ScorePanel;
    [SerializeField] GameObject GameOverPanel;
    [SerializeField] GameObject StartPanel;
    [SerializeField] int points;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        gm = this;
        GameOverPanel.SetActive(false);
        ScorePanel.SetActive(false);
        StartPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            ScorePanel.SetActive(true);
            StartPanel.SetActive(false);
            Time.timeScale = 1f;
        }
            
    }
    void AddPoint()
    {
        points++;
        score.GetComponent<TMP_Text>().text = points.ToString();
    }
    public void Again()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("GameReset");
    }
    public void Death() 
    {
        ScorePanel.SetActive(false);
        GameOverPanel.SetActive(true); 
        Time.timeScale = 0f;
    }
}
