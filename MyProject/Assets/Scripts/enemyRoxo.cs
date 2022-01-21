using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyRoxo : MonoBehaviour
{
    public GameObject bullet; 

    float fireRate;
    float nextFire;

    void Start(){
        fireRate = 3f;
        nextFire = Time.time;
    }

    void Update(){
        CheckIfTimeToFire();
    }

    void CheckIfTimeToFire(){
        if(Time.time > nextFire) {
            Instantiate (bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
}
