using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour {
    public GameManager gm;
    public Ball ball;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gm.UpdateLives(-1);
        ball.restart();
        if(gm.getLives() == 0)
        {
            if (gm.getMeilleurScore() < gm.getScore())
                gm.setMeilleurScore(gm.getScore());
            gm.setLives(3);
            gm.setScore(0);
           
            SceneManager.LoadScene("Game Over");
        }

    }

}
