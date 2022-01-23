using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class door : MonoBehaviour
{
    [SerializeField]
    public Text unlockText;
    public Text lockedText;
    public GameObject coll;

    private bool unlockAllowed;

    GameObject hero;

    // Start is called before the first frame update
    void Start()
    {
        unlockText.gameObject.SetActive(false);
        lockedText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if( unlockAllowed && Input.GetKeyDown(KeyCode.F) && hero.GetComponent<HeroController>().gotkey.Equals(true)){
            Unlock();
        }
    }

    private void OnTriggerEnter2D(Collider2D col){
        if( col.gameObject.name.Equals("hero")){
            hero = col.gameObject;
            if(hero.GetComponent<HeroController>().gotkey.Equals(true)){
                unlockText.gameObject.SetActive(true);
                unlockAllowed = true;
            }
            else{
                lockedText.gameObject.SetActive(true);
            }
            
        }
    }

    private void OnTriggerExit2D(Collider2D col){
        if( col.gameObject.name.Equals("hero")){
            unlockText.gameObject.SetActive(false);
            lockedText.gameObject.SetActive(false);
            unlockAllowed = false;

        }
    } 

    private void Unlock(){
        hero.GetComponent<HeroController>().gotkey = false;
        Destroy(gameObject);
        Destroy(coll);
    }
}
