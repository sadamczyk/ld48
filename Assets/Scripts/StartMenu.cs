using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void loadLevel() {
        SceneManager.LoadScene("Level1");
    }
}
