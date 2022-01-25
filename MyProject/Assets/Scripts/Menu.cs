using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void Restart(){

        Debug.Log("Game over");

        //GameManager.ChangeScene(GameManager.levelOneScene);
        GameManager.ChangeScene(GameManager.gameOverScene, GameManager.gameOverScene);
    }

    public void seeControls(){

        //GameManager.ChangeScene(GameManager.levelOneScene);
        GameManager.LoadNextLevel(GameManager.controlMenu);
    }

    public void seeCredits(){

        //GameManager.ChangeScene(GameManager.levelOneScene);
        GameManager.LoadNextLevel(GameManager.creditScene);
    }

    public void seeMenu(){

        //GameManager.ChangeScene(GameManager.levelOneScene);
        GameManager.LoadNextLevel(GameManager.startMenu);
    }

    public void play(){

        //GameManager.ChangeScene(GameManager.levelOneScene);
        GameManager.LoadNextLevel(GameManager.levelOneScene);
    }


}
