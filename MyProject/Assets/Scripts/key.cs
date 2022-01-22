using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    public enum InteractionType{NONE,PickUp,Examine}
    public InteractionType tipo;

    void Reset(){
        GetComponent<Collider2D>().isTrigger = true;
        gameObject.layer = 10;
    }
    public void Interact(){
        switch (tipo)
        {
            case InteractionType.PickUp:
            FindObjectOfType<InteractionSystem>().PickUpItem(gameObject);
            Debug.Log("Pick up");
            gameObject.SetActive(false);
            
            break;
            case InteractionType.Examine:
            Debug.Log("Examine");
            break;
            default:
            Debug.Log("Null Item");
            break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
