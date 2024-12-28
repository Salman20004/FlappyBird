using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class LogicScript : MonoBehaviour
{
    public int playerscore;
    public TextMeshProUGUI scoreText;
    public GameObject GameOverScreen ;
    public AudioSource coinSFX;
    [ContextMenu("Increase Score")]
    public void addscore(int scoreToAdd)
    {
        playerscore += scoreToAdd;
        scoreText.text = playerscore.ToString();
        coinSFX.Play();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver()
    {
        GameOverScreen.SetActive(true);
    }
}
