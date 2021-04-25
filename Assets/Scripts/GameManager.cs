using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject gameOverUI;

    // Start is called before the first frame update
    void Start()
    {
        gameOverUI = GameObject.FindGameObjectWithTag("Finish");
        gameOverUI.SetActive(false);
    }

    public void gameOver() {
        gameOverUI.SetActive(true);
        Time.timeScale = 0;
    }
}
