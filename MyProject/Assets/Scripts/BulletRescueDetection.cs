using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRescueDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D hitInfo)
    {

        Prisoner prisoner = hitInfo.GetComponent<Prisoner>();
        if (prisoner != null)
        {
            prisoner.Save();
            Destroy(gameObject);
        }

        if (!hitInfo.gameObject.tag.Equals("fossa"))
        {
            Destroy(gameObject);
        }

    }

}
