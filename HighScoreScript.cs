using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HighScoreScript : MonoBehaviour
{
    private BirdScript Bird;
    public TextMeshProUGUI HighScoreText;
    public int Highscore;
    private LogicScript logic;

    void Start()
    {
        Bird = GameObject.FindGameObjectWithTag("Bird1").GetComponent<BirdScript>();
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();

        if (PlayerPrefs.HasKey("Highscore"))
        {
            Highscore = PlayerPrefs.GetInt("Highscore");
            PlayerPrefs.SetInt("Highscore",Highscore);

        }
        else
        {
            Highscore = 0;
            PlayerPrefs.SetInt("Highscore", Highscore);
        }
        
    }

    void Update()
    {
        logic.scoreText.text = logic.playerscore.ToString();
        HighScoreText.text = "HI Score : "+Highscore.ToString();
       
        if (logic.playerscore > PlayerPrefs.GetInt("Highscore"))
        {
            SaveHighScore();
        }
    }
    public void SaveHighScore()
    {
        
            Highscore = logic.playerscore ;
            PlayerPrefs.SetInt("Highscore", Highscore);

        
    }
}
