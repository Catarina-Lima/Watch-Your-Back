using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D (Collider2D hitInfo) {
        
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if(enemy != null){
            enemy.TakeDamage(50);
        }
        if(!hitInfo.gameObject.tag.Equals("fossa")){
            Destroy(gameObject);
        }
        UnityEngine.Debug.Log(hitInfo.name);
        
    }
}
