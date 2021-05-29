using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    public GameObject manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == this.tag)
        {
          
            manager.GetComponent<Asociar_palabra_imagen>().checkThat= manager.GetComponent<Asociar_palabra_imagen>().checkThat + 1;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.tag == this.tag)
        {
           
            manager.GetComponent<Asociar_palabra_imagen>().checkThat = manager.GetComponent<Asociar_palabra_imagen>().checkThat - 1;
        }
    }

}
