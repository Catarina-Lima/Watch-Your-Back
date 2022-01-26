using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip shootSound;
    public static AudioClip gameOverSound;
    public static AudioClip enemyPurpleSound;
    public static AudioClip victorySound;
    public static AudioClip saveSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {

        shootSound = Resources.Load<AudioClip>("shoot_hero");
        gameOverSound = Resources.Load<AudioClip>("game_over");
        enemyPurpleSound = Resources.Load<AudioClip>("shoot_purple");
        victorySound = Resources.Load<AudioClip>("victory");
        saveSound = Resources.Load<AudioClip>("save_prisoner");

        audioSrc = GetComponent<AudioSource>();
        audioSrc.volume = 0.1f;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch(clip)
        {
            case "shoot":
                audioSrc.PlayOneShot(shootSound);
                break;
            case "gameOver":
                audioSrc.PlayOneShot(gameOverSound);
                break;
            case "purple":
                audioSrc.PlayOneShot(enemyPurpleSound);
                break;
            case "victory":
                audioSrc.PlayOneShot(victorySound);
                break;
            case "saveP":
                audioSrc.PlayOneShot(saveSound);
                break;
        }
    }
}
