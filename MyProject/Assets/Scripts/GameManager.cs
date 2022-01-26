using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager {

    public static int gameOverScene = 6;
    public static int startMenu = 0;
    public static int controlMenu = 1;
    public static int creditScene = 2;
    public static int movingScene = 3;
    public static int levelOneScene = 4 ;
    public static int mainLevel = 5;

    static int atual;

    public static void ChangeScene(int scene) {

        SceneManager.LoadScene(scene);
    }

    public static void ChangeScene(int sceneACarregar, int atualScene) {

        int load = sceneACarregar;

        if (atualScene == gameOverScene){
            load = atual;
        }
        else if (sceneACarregar == gameOverScene){
            atual = atualScene;

        }
        SceneManager.LoadScene(load);
    }


    public static void LoadNextLevel(int scene) {

        SceneManager.LoadScene(scene);
    }


}
