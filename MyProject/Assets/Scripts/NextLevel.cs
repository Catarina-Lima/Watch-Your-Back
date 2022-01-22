using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{

    public int nextLevel;

    void OnTriggerEnter2D (Collider2D hitInfo) {

        GameManager.ChangeScene(nextLevel);
    }
}
