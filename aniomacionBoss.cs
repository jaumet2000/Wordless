using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class aniomacionBoss : MonoBehaviour
{
    GameObject personaje;
    public GameObject posicion;
    public GameObject barradevida;
    public int vida;
    public Image vidarestante;
    public GameObject jefe;
    public AudioSource sonido;
    // Start is called before the first frame update
    void Start()
    {
        barradevida.SetActive(false);

        //PlayerPrefs.SetInt("boss", 1200);



        gameObject.GetComponent<Animator>().speed=0;
        if (PlayerPrefs.GetInt("misiones") == 30)
        {
            personaje = GameObject.FindGameObjectWithTag("Player");

        }
        if (PlayerPrefs.GetInt("activateBoss") == 1)
        {
            if (PlayerPrefs.GetInt("boss") == 200)
            {
                PlayerPrefs.SetInt("boss", 1);
            }
            if (PlayerPrefs.GetInt("boss") == 400)
            {
                PlayerPrefs.SetInt("boss", 200);
            }
            if (PlayerPrefs.GetInt("boss") == 600)
            {
                PlayerPrefs.SetInt("boss", 400);
            }
            if (PlayerPrefs.GetInt("boss") == 800)
            {
                PlayerPrefs.SetInt("boss", 600);
            }
            if (PlayerPrefs.GetInt("boss") == 1000)
            {
                PlayerPrefs.SetInt("boss", 800);
            }
            if (PlayerPrefs.GetInt("boss") == 1200)
            {
                PlayerPrefs.SetInt("boss", 1000);
            }
        }

    }



    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            sonido.Play();
            //PlayerPrefs.SetInt("misiones", 30);
            PlayerPrefs.SetInt("activateBoss", 1);
            barradevida.SetActive(true);
            print(1);
            gameObject.GetComponent<Animator>().speed = 1;
            StartCoroutine(minijuego());
        }
    }



    IEnumerator minijuego()
    {
        GameObject.FindGameObjectWithTag("mainController").GetComponent<Manager>().GuardarPosicion();
        yield return new WaitForSeconds(1.7f);
        int rESC = Random.Range(0, 7);

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

    void Update()
    {

      
        vida =PlayerPrefs.GetInt("boss");

        vidarestante.fillAmount = vida/1000;

        if (PlayerPrefs.GetInt("boss") == 1)
        {
            Debug.Log("des");
            Destroy(jefe);
            barradevida.SetActive(false);
            PlayerPrefs.SetInt("si", 2);
        }
    }

    IEnumerator barra()
    {
        yield return new WaitForSeconds(2f);
        barradevida.SetActive(false);
    }
}
