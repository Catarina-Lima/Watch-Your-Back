using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowPlayer : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField]
    Transform target;

    [SerializeField]
    float speed;

    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        Chase();
    }

    void Chase()
    {
        Vector2 direction = target.position - transform.position;
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
        //rb.AddForce((direction).normalized * speed);

    }
}
