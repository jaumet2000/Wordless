using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cartel : MonoBehaviour
{
    public GameObject foto;
    // Start is called before the first frame update
    void Awake()
    {
        print("xd");
        foto.SetActive(false);

        print("xd2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            foto.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            foto.SetActive(false);

        }
    }
}
