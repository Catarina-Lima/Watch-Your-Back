using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDetectHero : MonoBehaviour
{
    float moveSpeed = 7f;

    Rigidbody2D rb;

    public GameObject target;
    Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.Find("hero");
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2 (moveDirection.x, moveDirection.y);
        Destroy (gameObject, 3f);
    }

    void OnTriggerEnter2D (Collider2D col){
        if(col.gameObject.name.Equals("hero") || col.gameObject.tag.Equals("wall") ){
            Debug.Log("Hit!");
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
