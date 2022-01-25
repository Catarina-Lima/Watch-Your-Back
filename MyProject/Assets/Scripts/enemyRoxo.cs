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

             GameObject target = GameObject.Find("hero");

            Vector3 difference = target.transform.position - gameObject.transform.position;
            float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg; 
            
            Instantiate (bullet, transform.position, Quaternion.Euler(0.0f, 0.0f, rotationZ));
            nextFire = Time.time + fireRate;
        }
    }
}
