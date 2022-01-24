using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prisoner : MonoBehaviour
{

    public float health = 100;
    public Transform explosion;

    public void Save()
    {
        GameObject exploder = ((Transform)Instantiate(explosion, this.transform.position, this.transform.rotation)).gameObject;
        Destroy(gameObject, 0.2f);
        Destroy(exploder, 1.0f);
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
            GameManager.ChangeScene(GameManager.gameOverScene, SceneManager.GetActiveScene().buildIndex);
        }

        health -= (value);


    }

}
