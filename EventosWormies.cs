using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventosWormies : MonoBehaviour
{

    //public GameObject collider;

    public bool fuera;
    public int r;
    public GameObject wormie;
    public GameObject musica;
    public AudioSource epica;
    public int dificultad;
    
    // Start is called before the first frame update
    void Start()
    {
        fuera = false;
        r = Random.Range(0, dificultad);
    }

    // Update is called once per frame
    void Update()
    {
        if (fuera)
        {
             
            if (r == 10)
            {
                //loadScene

                
                print("Ultima posicion: " + GameObject.FindGameObjectWithTag("Player").transform.position);
                //SceneManager.LoadScene("asociar_palabra_imagen");
                StartCoroutine(aparicion());
                fuera = false;
            }
            else
            {
                r = Random.Range(0, dificultad);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            print("dentro");
            fuera = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            print("fuera");
            fuera = false;

        }
        

    }


    public IEnumerator aparicion()
    {
        int Xw = 0;
        int Yw = 0;

        int r = Random.Range(0, 6);

        switch (r)
        {
            case 0:
                Xw = 5;
                Yw = 0;
                break;
            case 1:
                Xw = 0;
                Yw = 15;
                break;
            case 2:
                Xw = 5;
                Yw = 15;
                break;
            case 3:
                Xw = -15;
                Yw = 0;
                break;
            case 4:
                Xw = 0;
                Yw = -15;
                break;
            case 5:
                Xw = -15;
                Yw = -15;
                break;
        }


        Vector3 posPlayer = new Vector3(GameObject.FindGameObjectWithTag("Player").transform.position.x+Xw, GameObject.FindGameObjectWithTag("Player").transform.position.y, GameObject.FindGameObjectWithTag("Player").transform.position.z +Yw);
        //musica.GetComponent<AudioSource>().clip = epica;
        epica.Play();
        Instantiate(wormie, posPlayer, GameObject.FindGameObjectWithTag("Player").transform.rotation);
        yield return new WaitForSeconds(2f);
        GameObject.FindGameObjectWithTag("mainController").GetComponent<Manager>().GuardarPosicion();
        int rESC = Random.Range(0,7);

        if (rESC == 0)
        {
            SceneManager.LoadScene("asociar_palabra_imagen");
        }
        if (rESC == 1)
        {
            SceneManager.LoadScene("Anagramas");
        }
        if (rESC == 2)
        {
            SceneManager.LoadScene("Categoria");
        }
        if (rESC == 3)
        {
            SceneManager.LoadScene("Intrusos");
        }
        if (rESC == 4)
        {
            SceneManager.LoadScene("CrearPalabras");

        }
        if (rESC == 5)
        {
            SceneManager.LoadScene("Frases");

        }
        if (rESC == 6)
        {
            SceneManager.LoadScene("Frase-Pregunta");

        }
    }
}

