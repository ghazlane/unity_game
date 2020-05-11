using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour

{
    public static int lives = 3;
    public static int score = 0;
    public static int meilleurScore = 0;
    public Text LiveText;
    public Text ScoreText;
    public Text MeilleurScoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        if (LiveText != null && ScoreText != null)
        {
            LiveText.text = "Lives : " + lives;
            ScoreText.text = "Score : " + score;
        }
        if (MeilleurScoreText != null)
            MeilleurScoreText.text = "Best Score : " + meilleurScore;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getLives()
    {
        int l = lives;
        return l;

    }

    public void setLives(int l)
    {
        lives = l;

    }

    public void setScore(int s)
    {
        score = s;

    }

    public int getScore()
    {
        return score;
    }

    public int getMeilleurScore()
    {
        return meilleurScore;
    }


    public void setMeilleurScore(int ms)
    {
        meilleurScore = ms;

    }


    public void UpdateLives(int changeInLives)
    {
        lives += changeInLives;
        LiveText.text = "Lives : " + lives;

    }

    public void UpdateScores(int points)
    {
        score += points;
        ScoreText.text = "Score : " + score;
    }
}
