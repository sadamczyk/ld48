using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 6; // tiles per second

    public Vector2 facingDirection;

    // Start is called before the first frame update
    void Start()
    {
        facingDirection = new Vector2(1, 0);

        // Load persisted data from GlobalObject
        loadGlobalPlayerData();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (direction != Vector2.zero) {
            transform.Translate(direction * speed * Time.deltaTime);
            facingDirection = direction.normalized;
        }
    }

    public void loadGlobalPlayerData() {
        GetComponent<Health>().health = GlobalControl.Instance.health;
    }
}
