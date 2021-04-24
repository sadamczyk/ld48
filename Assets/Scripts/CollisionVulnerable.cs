using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionVulnerable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Enemy")) {
            GetComponent<Health>().decreaseHealth(10); // Keep damage value on enemy? Or just make a big switch case here for different enemy types
        }
    }
}
