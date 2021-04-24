using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    Slider healthbar;
    Health playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
        healthbar = GetComponent<Slider>();
        healthbar.maxValue = playerHealth.maxHealth;
        healthbar.value = playerHealth.health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setHealth(int hp) {
        healthbar.value = hp;
    }
}
