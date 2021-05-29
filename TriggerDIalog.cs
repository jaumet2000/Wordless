using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDIalog : MonoBehaviour
{
    public Dialogos Dialogo;

    void Start()
    {
        
        
        
    }
    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
           
            FindObjectOfType<DialogSystem>().StartDialogue(Dialogo);
        }
            
        
    }
}
