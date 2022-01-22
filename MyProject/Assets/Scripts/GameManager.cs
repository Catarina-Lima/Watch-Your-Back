using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public static class GameManager {

    public static int levelOneScene = 0;
    public static int gameOverScene = 1;


    public static void ChangeScene(int scene) {

        SceneManager.LoadScene(scene);
    }


}
