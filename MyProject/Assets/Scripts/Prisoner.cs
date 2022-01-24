using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prisoner : MonoBehaviour
{

    public float health = 100;

    public void Save()
    {
        Destroy(gameObject);
    }

    public void LoseHealth(int value)
    {

        //if (health <= 0)
        //{
        //    GameManager.ChangeScene(GameManager.gameOverScene);
        //    return;
        //}

        if (health <= 20)
        {
            GameManager.ChangeScene(GameManager.gameOverScene);
        }

        health -= (value);

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Return))
                LoseHealth(25);

        }
    }

}
