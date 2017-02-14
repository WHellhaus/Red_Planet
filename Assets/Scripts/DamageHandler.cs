using UnityEngine;
using System.Collections;

public class DamageHandler : MonoBehaviour {
    public int health;
    void OnTriggerEnter2D ()
    {
        health-= 10;
        if (health == 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(this.gameObject);
    }
}
