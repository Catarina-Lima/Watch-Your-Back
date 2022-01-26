using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletRescueDetection : MonoBehaviour
{

    List<string> enemies = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        enemies.Add("green_enemy");
        enemies.Add("purple_enemy");
        enemies.Add("orange_enemy");

        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D hitInfo)
    {

        Prisoner prisoner = hitInfo.GetComponent<Prisoner>();
        if (prisoner != null)
        {
            int end = 0;
            GameObject[] prisoners = GameObject.FindGameObjectsWithTag("prisoner");
            if(prisoners.Length ==  1) {
                end = 1;
                
            }
    
            prisoner.Save();
            if(end == 1){
                endGame();
                return;
            }

            SoundManager.PlaySound("saveP");
            Destroy(gameObject);
            

        }

        else if(enemies.Contains(hitInfo.gameObject.tag)) {
            GameManager.ChangeScene(GameManager.gameOverScene, SceneManager.GetActiveScene().buildIndex);
        }

        else if (!hitInfo.gameObject.tag.Equals("fossa"))
        {
            Destroy(gameObject);
        }

    }



    void endGame() {

        Debug.Log("acabou");
        Debug.Log(SceneManager.GetActiveScene().buildIndex);

        if(SceneManager.GetActiveScene().buildIndex == 5){
                GameManager.LoadNextLevel(GameManager.startMenu);
            }
        else {
            GameManager.ChangeScene(SceneManager.GetActiveScene().buildIndex + 1, SceneManager.GetActiveScene().buildIndex);
        }
    }

}
