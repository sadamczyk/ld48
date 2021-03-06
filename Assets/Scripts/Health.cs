using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    public int health;
    public int maxHealth;
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    public bool isDead() {
        return health == 0;
    }

    public void decreaseHealth(int value) {
        health = Math.Max(0, health - value);

        if (healthBar) {
            healthBar.setHealth(health);
        }

        if (isDead()) {
            onDeath();
        }
    }

    public void increaseHealth(int value) {
        health = Math.Min(maxHealth, health + value);
        
        if (healthBar) {
            healthBar.setHealth(health);
        }
    }

    public void onDeath() {
        switch (gameObject.tag) {
            case "Player":
                GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().gameOver();
                break;
            case "Enemy":
                Destroy(gameObject);
                break;
        }
    }
}
