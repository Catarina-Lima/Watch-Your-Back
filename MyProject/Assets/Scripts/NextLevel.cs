using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{

    public int nextLevel;

    void OnTriggerEnter2D (Collider2D hitInfo) {

        Player player = hitInfo.GetComponent<Player>();
        if(player != null){
            GameManager.ChangeScene(nextLevel);
        }
        
    }
}
