using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionSystem : MonoBehaviour
{
    [Header("Detection Parameters")]
    public Transform detectionPoint;
    private const float detectionRadius = 0.2f;
    public LayerMask detectionLayer;
    public GameObject detectedObject;
    [Header("Others")]
    public List<GameObject> pickedItems = new List<GameObject>();
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if(DetectObject()){
            if(InteractInput()){
                detectedObject.GetComponent<key>().Interact();
            }
        }
        
    }

    bool InteractInput(){
        return Input.GetKeyDown(KeyCode.E);
    }

    bool DetectObject(){
        Collider2D obj = Physics2D.OverlapCircle(detectionPoint.position,detectionRadius,detectionLayer);

        if(obj == null){
            detectedObject = null;
            return false;
        }else{
            detectedObject = obj.gameObject;
            return true;
        }
    }

    public void PickUpItem(GameObject key){
        pickedItems.Add(key);
    }
}