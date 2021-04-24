using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
    public Rigidbody2D projectile;

    public float speed = 1;

    PlayerInputHandler pih;

    // Start is called before the first frame update
    void Start()
    {
        pih = GetComponent<PlayerInputHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Rigidbody2D clone = Instantiate(projectile, (Vector2) transform.position + pih.facingDirection, Quaternion.identity);
            clone.transform.SetParent(GameObject.Find("Projectiles").transform);

            clone.velocity = pih.facingDirection * speed;
        }
    }
}
