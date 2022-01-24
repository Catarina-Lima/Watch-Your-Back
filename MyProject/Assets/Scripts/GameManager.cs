using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public static class GameManager {

    public static int levelOneScene = 1;
    public static int gameOverScene = 0;

    static int atual;


    public static void ChangeScene(int sceneACarregar, int atualScene) {

        int load = gameOverScene;

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
