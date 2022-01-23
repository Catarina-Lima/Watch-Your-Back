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
            GameManager.ChangeScene(GameManager.gameOverScene);
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

    
    void OnCollisionEnter2D (Collision2D hitInfo) {

        if(hitInfo.collider.tag == "enemy"){
            LoseHealth(25);
        }
    }



}
