using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int health = 100;
    //public Transform explosion;

    // Start is called before the first frame update
    public void TakeDamage (int damage) {

        //UnityEngine.Debug.Log(health);
        health -= damage;
        UnityEngine.Debug.Log(health);

        if(health <= 0) {
            Die();

        }

    }


    void Die(){
        //GameObject exploder = ((Transform)Instantiate(explosion, this.transform.position, this.transform.rotation)).gameObject;
        //Destroy(gameObject, 0.2f);
        //Destroy(exploder, 1.0f);
        Destroy(gameObject);
    }




}
