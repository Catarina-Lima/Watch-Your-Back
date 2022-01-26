using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScreenKey : MonoBehaviour
{

        public Image key;

    // Start is called before the first frame update
    void Start()
    {
        key.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void lockDoor() {

        key.gameObject.SetActive(true);
    }

    public void unLockDoor(){
        key.gameObject.SetActive(false);
    }


}
