using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class key : MonoBehaviour
{
    [SerializeField]
    public Text pickUpText;

    private bool pickUpAllowed;

    GameObject hero;

    // Start is called before the first frame update
    void Start()
    {
        pickUpText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if( pickUpAllowed && Input.GetKeyDown(KeyCode.F)){
            PickUp();
        }   
    }

    private void OnTriggerEnter2D(Collider2D col){
        if( col.gameObject.name.Equals("hero")){
            hero = col.gameObject;
            pickUpText.gameObject.SetActive(true);
            pickUpAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D col){
        if( col.gameObject.name.Equals("hero")){
            pickUpText.gameObject.SetActive(false);
            pickUpAllowed = false;
        }
    } 

    private void PickUp(){
        hero.GetComponent<HeroController>().gotkey = true;
        Destroy(gameObject);

    }
}
