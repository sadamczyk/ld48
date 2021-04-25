using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayLevel : MonoBehaviour
{
    public void replayLevel() {
        Debug.Log("REPLAY LEVEL!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
