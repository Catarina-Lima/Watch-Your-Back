using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesUpDown : MonoBehaviour
{
    public GameObject spikes;
  
    /*
    IEnumerator ShowAndHide( GameObject go, float delay ){
        go.SetActive(true);
        yield return new WaitForSeconds(delay);
        go.SetActive(false);
    }
    */

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Show",3f);
    }

    void Show()
    {
     spikes.SetActive(true);
     Invoke("Hide",3f);
    }

    void Hide()
 {
     spikes.SetActive(false); 
     Invoke("Show",3f);
 }

    // Update is called once per frame
    void Update()
    {
       //StartCoroutine( ShowAndHide(ob, 1.0f) ); 
    }
}
