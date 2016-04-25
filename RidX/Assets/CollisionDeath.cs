using UnityEngine;
using System.Collections;

public class CollisionDeath : MonoBehaviour {

    int health = 1;
    void OnTriggerEnter2D(){
        Debug.Log("Death!");
        health--;
        if(health <= 0)
            Die();
    }
    void Die() {
        Destroy(gameObject);
    }
}
