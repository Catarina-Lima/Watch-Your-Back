using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private bool rescueGun = false;
    GameObject hero;

    void Start()
    {

    }

    void Update()
    {
        if(rescueGun)
        {
            Collect();
        }
    }

    public void Collect()
    {
        hero.GetComponent<HeroController>().hasGun = true;
        hero.GetComponent<HeroController>().rechargeGun();
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.name.Equals("hero"))
        {
            hero = hitInfo.gameObject;
            rescueGun = true;
            GameObject ui = GameObject.Find("RescueBullets");
            ui.GetComponent<UIScreen>().canRescue();
        }

    }
}
