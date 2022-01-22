using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Image fillBar;
    //  Eh 80 - para equiparar ah quantidade mostrada
    public float health;

    //The Fill bar can only be seen from 0.2 to 1
    const float howMuchIsShowing = 0.8f;


    /*
    Usar valores de 0 a 100  
    */
    public void LoseHealth (int value) {
        
        if (health <= 0)
            return;

        health -= (value * howMuchIsShowing) ;
        fillBar.fillAmount = (float) (health / 100.0);

        if(health <= 20) {
            Debug.Log("Died");
        }

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        LoseHealth(25);
        
    }


    void OnTriggerEnter2D (Collider2D hitInfo) {
        
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if(enemy != null){
            LoseHealth(25);
        }
    }


}
