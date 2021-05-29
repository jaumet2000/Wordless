using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormieMov : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position, 0.01f);
        transform.LookAt(GameObject.FindGameObjectWithTag("Player").transform.position);
    }
}
