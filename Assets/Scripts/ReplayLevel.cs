using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayLevel : MonoBehaviour
{
    public void replayLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().loadGlobalPlayerData(); // Reload global data
        Time.timeScale = 1;
    }
}
