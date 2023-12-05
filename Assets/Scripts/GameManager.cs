using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text scoreText;

    public float worldScrollingSpeed = 0.2f;

    private float score;
    public bool inGame;
    public GameObject resetButton;

    void Start()
    {
        if (instance == null) { instance = this; }
        InitializeGame();
    }

    void FixedUpdate()
    {
        score += worldScrollingSpeed;
        UpdateOnScreenScore();
    }
    void UpdateOnScreenScore()
    {
        scoreText.text = score.ToString("0");
    }
    void InitializeGame()
    {
        inGame = true;
        resetButton.SetActive(false);
    }
    public void GameOver ()
    {
        inGame = false;
        resetButton.SetActive(true);
    }
}