using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
//using UnityEngine;
//using String;
using System;

public class playerActions : MonoBehaviour
{

    public float bulletSpeed = 60.0f;

    public GameObject hero;

    private Vector3 target;

    public GameObject bulletPrefab;
    public GameObject bulletRescue;

    public Transform firePoint;

    // Update is called once per frame
    void Update()
    {
        LookAtMouse();
    }

    void LookAtMouse () {

        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));

        Vector3 difference = target - hero.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        if (rotationZ > 90 || rotationZ < -90){
            hero.transform.localScale = new Vector3(1.2f, -1.2f, 1.0f);
            //hero.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        }
        else {
            hero.transform.localScale = new Vector3(1.2f, 1.2f, 1f);
           //hero.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        }

        hero.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);




        Vector3 clickedPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 ballCenter = hero.transform.position;

        Vector3 forceDirection = (ballCenter  - clickedPosition).normalized;
        // UnityEngine.Debug.Log(String.Format("{0}",click));

        if (Input.GetMouseButtonDown(0)) {
           // System.Diagnostics.Debug.WriteLine("entrou");
            //UnityEngine.Debug.Log(String.Format("entrou"));
            float distance = difference.magnitude;
            Vector2 direction = difference / distance;
            fireBullet(direction, rotationZ);
            //goAway();

            hero.GetComponent<Rigidbody2D>().AddForce(forceDirection * 10, ForceMode2D.Impulse);
            
            
            //difference = hero.transform.position - target;
            //hero.transform.position = new Vector3(difference.x, difference.y, -2);
        } else {
            //hero.GetComponent<Rigidbody2D>().AddForce(forceDirection * 0, ForceMode2D.Impulse);
        }

        if (hero.GetComponent<HeroController>().hasGun)
        {
            if (Input.GetMouseButtonDown(1) && hero.GetComponent<HeroController>().hasBullets())
            {
                UnityEngine.Debug.Log(String.Format("DISPAROU"));
                float distance = difference.magnitude;
                Vector2 direction = difference / distance;
                hero.GetComponent<HeroController>().fireBulletRescue();
                rescueBullet(direction, rotationZ);
            }
        }

    }

    void fireBullet(Vector2 direction, float rotationZ){
        SoundManager.PlaySound("shoot");
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = firePoint.position;//hero.transform.position;
        b.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        b.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;

        //hero.transform.position = direction;
        //hero.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
    }

    void rescueBullet(Vector2 direction, float rotationZ)
    {
        SoundManager.PlaySound("shoot");
        GameObject br = Instantiate(bulletRescue) as GameObject;
        br.transform.position = firePoint.position;
        br.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        br.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
    }


    void goAway() {

        //Vector2 mouseVectorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //hero.transform.position = -transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 12));


        //Vector2 ForceVector = (mouseVectorPosition - heroVectorPosition).normalized;
        //hero.GetComponent<Rigidbody2D>().AddForce(ForceVector * movementForce * -1.0);
    }
}
