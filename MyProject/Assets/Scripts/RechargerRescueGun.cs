using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class RechargerRescueGun : MonoBehaviour
{

    GameObject hero;
    private bool rechargeAllowed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rechargeAllowed && Input.GetKeyDown(KeyCode.R))
        {
            UnityEngine.Debug.Log(String.Format("DONE"));
            Recharge();
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.name.Equals("hero"))
        {
            UnityEngine.Debug.Log(String.Format("Recarregar"));
            hero = hitInfo.gameObject;
            rechargeAllowed = true;
        }

    }

    void OnTriggerExit2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.name.Equals("hero"))
        {
            rechargeAllowed = false;
        }
    }

    void Recharge()
    {
        hero.GetComponent<HeroController>().rechargeGun();
    }
}
