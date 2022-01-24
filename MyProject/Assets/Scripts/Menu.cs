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
}
