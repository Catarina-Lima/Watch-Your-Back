using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class alavanca : MonoBehaviour
{
    [SerializeField]
    public Text switchText;
    public GameObject fire1;
    public GameObject fire2;
    public GameObject fire3;
    public GameObject fire4;
    public GameObject fire5;
    public GameObject fire6;

    private bool switchAllowed;

    GameObject hero;
    

    // Start is called before the first frame update
    void Start()
    {
        switchText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if( switchAllowed && Input.GetKeyDown(KeyCode.F)){
            SwicthOff();
        }   
    }

    private void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.name.Equals("hero")){
            hero = col.gameObject;
            switchText.gameObject.SetActive(true);
            switchAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D col){
        if( col.gameObject.name.Equals("hero")){
            if(switchText != null) {
                switchText.gameObject.SetActive(false);
            }
            
            switchAllowed = false;
        }
    }

    private void SwicthOff(){
        Destroy(fire1);
        Destroy(fire2);
        Destroy(fire3);
        Destroy(fire4);
        Destroy(fire5);
        Destroy(fire6);
        Destroy(switchText);
    }
}
