using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{

    public int nextLevel;

    void OnTriggerEnter2D (Collider2D hitInfo) {

        HealthBar player = hitInfo.GetComponent<HealthBar>();
        if(player != null){
             GameManager.ChangeScene(SceneManager.GetActiveScene().buildIndex + 1, SceneManager.GetActiveScene().buildIndex);
        }
        
    }
}
