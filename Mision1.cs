using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mision1 : MonoBehaviour
{
    public Text texto;
    

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("si", 0);
        texto.text = PlayerPrefs.GetString("mision");
        
    }

    // Update is called once per frame
    void Update()
    {

        if(PlayerPrefs.GetInt("misiones")==5)
        {
            texto.text = "- Habla con el Sabio";
            PlayerPrefs.SetInt("chica", 0);
            PlayerPrefs.SetInt("si", 0);
        }
        if (PlayerPrefs.GetInt("misiones") == 10)
        {
            texto.text = "- Busca y habla con el pescador en el pueblo pesquero";
            PlayerPrefs.SetInt("chica", 0);
            PlayerPrefs.SetInt("si", 0);
        }
        if (PlayerPrefs.GetInt("misiones") == 15)
        {
            texto.text = "- Investiga el ruido en el árbol milenario";
            PlayerPrefs.SetInt("chica", 0);
            PlayerPrefs.SetInt("si", 0);
        }
        if (PlayerPrefs.GetInt("misiones") == 20)
        {
            texto.text = "- Recupera la lluvia en la fuente milagrosa";
            PlayerPrefs.SetInt("si", 0);
        }
        if (PlayerPrefs.GetInt("misiones") == 25)
        {
            texto.text = "- Vuelve al árbol milenario";
            PlayerPrefs.SetInt("si", 1);

        }
        if (PlayerPrefs.GetInt("misiones") == 30)
        {
            texto.text = "- Descubre que está pasando en el castillo y salva la isla Waka Paka";
            PlayerPrefs.SetInt("si", 1);

        }
        if (PlayerPrefs.GetInt("misiones") == 35)
        {
            texto.text = "- Habla con el pescador";
            PlayerPrefs.SetInt("si", 2);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "inicio" && other.tag == "Player")
        {
            PlayerPrefs.SetInt("misiones", 5);
        }
        if (gameObject.tag == "sabio" && other.tag == "Player" && PlayerPrefs.GetInt("misiones") == 5)
        {
            PlayerPrefs.SetInt("misiones", 10);
        }
        if (gameObject.tag=="Pescador" && other.tag == "Player" && PlayerPrefs.GetInt("misiones") == 10)
        {
            gameObject.GetComponent<AudioSource>().Play();
            PlayerPrefs.SetInt("misiones", 15);
        }
        if (gameObject.tag == "chicaarbol" && other.tag == "Player" && PlayerPrefs.GetInt("chica") != 300 && PlayerPrefs.GetInt("misiones") == 15)
        {
            PlayerPrefs.SetInt("misiones", 20);
            PlayerPrefs.SetInt("chica", 300);
        }
        if (gameObject.tag == "fuente" && other.tag == "Player" && PlayerPrefs.GetInt("misiones") == 20)
        {
            PlayerPrefs.SetInt("misiones", 25);
        }
        if (gameObject.tag == "chicaarbol" && other.tag == "Player" && PlayerPrefs.GetInt("chica") == 300 && PlayerPrefs.GetInt("misiones") == 25)
        {
            PlayerPrefs.SetInt("misiones", 30);
            PlayerPrefs.SetInt("boss", 1200);
            PlayerPrefs.SetInt("activateBoss", 0);
        }
        if ( PlayerPrefs.GetInt("boss") == 1 && PlayerPrefs.GetInt("misiones") == 30)
        {
            PlayerPrefs.SetInt("misiones", 35);
        }

    }
}
