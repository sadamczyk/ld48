using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void loadLevel() {
        Debug.Log("TESTTT");
        SceneManager.LoadScene("Level1");
    }
}
