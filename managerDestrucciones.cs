using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerDestrucciones : MonoBehaviour
{
    public GameObject piedras1;
    public GameObject piedras2;
    public GameObject castillo;
    public GameObject wormie;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("misiones") >= 12)
        {
            Destroy(piedras1);
        }
        if (PlayerPrefs.GetInt("misiones") >= 16)
        {
            Destroy(piedras2);
        }
        if (PlayerPrefs.GetInt("misiones") >= 28)
        {
            Destroy(castillo);
        }
    }
}
