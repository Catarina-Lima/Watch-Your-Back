using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    public float speed = 5f;

    Rigidbody2D rb;
    PolygonCollider2D coll;

    public bool gotkey = false;

    Vector2 movement;

    Vector2 move;

    bool facingLeft;

    public bool hasGun = false;
    private int bullets = 0;


    public GameObject bulletsRescueUI;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<PolygonCollider2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        if (movement.x > 0 && facingLeft)
        {
        transform.localScale = new Vector3(3.34f, 3.62f, 1.58f);
        facingLeft = false;
        }
    if (movement.x < 0 && !facingLeft)
        {
        transform.localScale = new Vector3(-3.34f, 3.62f, 1.58f);
        facingLeft = true;
        }
    }

    public void rechargeGun()
    {
        if(bullets == 0)
        {
            bullets = 2;
            bulletsRescueUI.GetComponent<UIScreen>().allBullets();

        }
    }

    public bool hasBullets()
    {
        if(bullets > 0)
        {
            return true;
        } else
        {
            return false;
        }
    }

    public void fireBulletRescue()
    {

        if(bullets == 1){
            bulletsRescueUI.GetComponent<UIScreen>().hideLastBullet();
        }
        else {
            bulletsRescueUI.GetComponent<UIScreen>().hideBullet();
        }
        bullets -= 1;
    }

    /*
        void Move()
        {
            speed = 40;
        movex = Input.GetAxis("Horizontal");
        movey = Input.GetAxis("Vertical");
        move = new Vector2(movex * speed * Time.fixedDeltaTime, movey * speed * Time.fixedDeltaTime);
        rb.AddForce(move);
        if (movex > 0 && facingLeft)
            {
            transform.localScale = new Vector3(3.34f, 3.62f, 1.58f);
            facingLeft = false;
            }
        if (movex < 0 && !facingLeft)
            {
            transform.localScale = new Vector3(-3.34f, 3.62f, 1.58f);
            facingLeft = true;
            }
        }
        */
}
