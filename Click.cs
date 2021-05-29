using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Click : MonoBehaviour
{
    public int _turnSpeed = 5;
    private NavMeshAgent agente;

    public Animator animaciones;
    public Vector3 lastPos;
    public GameObject personaje;


    public bool correr;


    //camara
    public Transform target;
    public float smoothing = 5f;
    Vector3 offset;

    private void Awake()
    {
       
    }


    // Start is called before the first frame update
    void Start()
        
    {

        target = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - target.position;


        animaciones = GetComponent<Animator>();

        //GameObject.FindGameObjectWithTag("mainController").GetComponent<Manager>().Destruir();


        //if (GameObject.FindGameObjectWithTag("mainController").GetComponent<Manager>().personaje != null)
        //if (GameObject.FindGameObjectWithTag("mainController").GetComponent<Manager>().guardado)
        
       /* if (GameObject.FindGameObjectWithTag("mainController").GetComponent<Manager>().camara != null)
        {
            Debug.Log("bbb");
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>().position = transform.position = GameObject.FindGameObjectWithTag("mainController").GetComponent<Manager>().camara;
        }*/

        agente = GetComponent<NavMeshAgent>();
        GetComponent<NavMeshAgent>().SetDestination(transform.position);
        //GameObject.FindGameObjectWithTag("MainCamera").transform.position = transform.position;
        //GameObject.FindGameObjectWithTag("MainCamera").transform.position = target.transform.position;//GameObject.FindGameObjectWithTag("mainController").GetComponent<Manager>().camara;
    }

    
    // Update is called once per frame
    void Update()
    {
        lastPos = gameObject.transform.position;

        animaciones.SetBool("corriendo", correr);

        if (Input.GetMouseButton(1))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                agente.destination = hit.point;

                Vector3 lookPos = this.agente.destination - this.transform.position;
                lookPos.y = 0;
                Quaternion targetRot = Quaternion.LookRotation(lookPos);
                this.transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, Time.deltaTime * this._turnSpeed);

            }
        }
        StartCoroutine(contador(lastPos));
    }

    public IEnumerator contador(Vector3 lastPoss)
    {
        yield return new WaitForSeconds(0.01f);
        if (lastPoss != gameObject.transform.position)
        {
            correr = true;
        }
        else
        {
            correr = false;
        }
        //print(correr);
    }
}

