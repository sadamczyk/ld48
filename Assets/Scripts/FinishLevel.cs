using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            // Persist player data
            GlobalControl.Instance.health = other.GetComponent<Health>().health; // Check other instead of searching by tag?

            SceneManager.LoadScene("Level2");
        }
    }
}
