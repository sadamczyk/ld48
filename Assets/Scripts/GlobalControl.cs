using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour
{
    // Singleton
    public static GlobalControl Instance;

    // Properties
    public int health;

    void Awake() {
        if (Instance == null) {
            DontDestroyOnLoad(gameObject);
            Instance = this;

            // Initialize values at very beginning
            health = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>().maxHealth;
        } else if (Instance != this) {
            Destroy(gameObject);
        }
    }
}
