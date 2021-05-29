using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inicio : MonoBehaviour
{
    public int x;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (x == 2)
        {
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
    }

    public void boton()
    {
        x = x + 1;
    }
}
