using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScreen : MonoBehaviour
{

        public Text text;
        //direita
        public Image b1;
        //esquerda
        public Image b2;


    // Start is called before the first frame update
    void Start()
    {
        text.gameObject.SetActive(false);
        b2.gameObject.SetActive(false);
        b1.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void canRescue() {

        text.gameObject.SetActive(true);
        b2.gameObject.SetActive(true);
        b1.gameObject.SetActive(true);
    }

    public void allBullets(){
        b2.gameObject.SetActive(true);
        b1.gameObject.SetActive(true);
    }


    public void hideBullet(){

        b2.gameObject.SetActive(false);
    }

    public void hideLastBullet() {
        b1.gameObject.SetActive(false);
    }


}
