using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionesIntrusos : MonoBehaviour
{
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("xs");
        transform.position = new Vector3(Random.Range(-25, 29), Random.Range(-19, 12), 28.9f);
    }
}
