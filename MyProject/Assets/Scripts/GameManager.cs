using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public static class GameManager {

<<<<<<< Updated upstream
    public static int levelOneScene = 0;
    public static int gameOverScene = 1;
=======
    public static int creditScene = 6;
    public static int controlMenu = 5;
    public static int startMenu = 4;
    public static int mainLevel = 3;
    public static int levelTwoScene = 2;
    public static int levelOneScene = 1;
    public static int gameOverScene = 0;
>>>>>>> Stashed changes


    public static void ChangeScene(int scene) {

        SceneManager.LoadScene(scene);
    }


}
