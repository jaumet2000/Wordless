using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject botonEmpezar;
    public GameObject botonSalir;
    public GameObject botonAjustes;
    public GameObject botonvoz;
    public GameObject botonvolver;
    public GameObject botongraficos;

    private AudioSource AudioSrc;
    private float volume=1f;
    // Start is called before the first frame update
    void Start()
    {
        botonvoz.SetActive(false);
        botonvolver.SetActive(false);
        botongraficos.SetActive(false);
        AudioSrc.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        AudioSrc.volume = volume;
    }

    public void SetVolume(float vol)
    {
        volume = vol;
    }

    public void EscenaJuego()
    {
        SceneManager.LoadScene("Inicio");
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("Saliendo");
    }

    public void ajustes()
    {
        botonvoz.SetActive(true);
        botonvolver.SetActive(true);
        botongraficos.SetActive(true);

        botonEmpezar.SetActive(false);
        botonAjustes.SetActive(false);
        botonSalir.SetActive(false);
    }

    public void volver()
    {
        botonvoz.SetActive(false);
        botonvolver.SetActive(false);
        botongraficos.SetActive(false);

        botonEmpezar.SetActive(true);
        botonAjustes.SetActive(true);
        botonSalir.SetActive(true);
    }
}
