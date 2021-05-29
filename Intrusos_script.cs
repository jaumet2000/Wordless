using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Intrusos_script : MonoBehaviour
{
    

    public List<string> familia = new List<string>();
    public List<string> vehiculos = new List<string>();
    public List<string> comida = new List<string>();
    public List<string> deportes = new List<string>();
    public List<string> colores = new List<string>();
    public List<string> cocina = new List<string>();
    public List<string> animales = new List<string>();

    public GameObject uno;
    public GameObject dos;
    public GameObject tres;
    public GameObject cuatro;
    public GameObject cinco;
    public GameObject seis;

    public int random;

    public string select;
    void Awake()
    {
        familia.Add("Abuela");
        familia.Add("Primo");
        familia.Add("Hermano");
        familia.Add("Padre");
        familia.Add("Nieta");
        

        vehiculos.Add("Coche");
        vehiculos.Add("Camión");
        vehiculos.Add("Moto");
        vehiculos.Add("Bicicleta");
        vehiculos.Add("Avión");

        comida.Add("Pasta");
        comida.Add("Carne");
        comida.Add("Arroz");
        comida.Add("Pan");
        comida.Add("Sopa");

        deportes.Add("Fútbol");
        deportes.Add("Baloncesto");
        deportes.Add("Tenis");
        deportes.Add("Atletismo");
        deportes.Add("Ciclismo");

        colores.Add("Rojo");
        colores.Add("Amarillo");
        colores.Add("Verde");
        colores.Add("Azul");
        colores.Add("Violeta");

        cocina.Add("Tenedor");
        cocina.Add("Cuchara");
        cocina.Add("Cuchillo");
        cocina.Add("Sartén");
        cocina.Add("Espátula");

        animales.Add("León");
        animales.Add("Mono");
        animales.Add("Jirafa");
        animales.Add("Pájaro");
        animales.Add("Perro");




    }
    // Start is called before the first frame update
    void Start()
    {
        uno.transform.position = new Vector3(Random.Range(-25,29), Random.Range(-19, 12), 28.9f);
        dos.transform.position = new Vector3(Random.Range(-25, 29), Random.Range(-19, 12), 28.9f);
        tres.transform.position = new Vector3(Random.Range(-25, 29), Random.Range(-19, 12), 28.9f);
        cuatro.transform.position = new Vector3(Random.Range(-25, 29), Random.Range(-19, 12), 28.9f);
        cinco.transform.position = new Vector3(Random.Range(-25, 29), Random.Range(-19, 12), 28.9f);
        seis.transform.position = new Vector3(Random.Range(-25, 29), Random.Range(-19, 12), 28.9f);
        random = Random.Range(0,7);

        switch (random)
        {
            case 0:
                for (int i = 0; i < 6; i++)
                {

                    if (i == 0)
                    {
                        uno.GetComponent<TextMeshPro>().text = familia[i];
                    }
                    if (i == 1)
                    {
                        dos.GetComponent<TextMeshPro>().text = familia[i];
                    }
                    if (i == 2)
                    {
                        tres.GetComponent<TextMeshPro>().text = familia[i];
                    }
                    if (i == 3)
                    {
                        cuatro.GetComponent<TextMeshPro>().text = familia[i];
                    }
                    if (i == 4)
                    {
                        cinco.GetComponent<TextMeshPro>().text = familia[i];
                    }
                    if (i == 5)
                    {
                        RandomList();
                    }
                }

                break;
            case 1:
                for (int i = 0; i < 6; i++)
                {

                    if (i == 0)
                    {
                        uno.GetComponent<TextMeshPro>().text = vehiculos[i];
                    }
                    if (i == 1)
                    {
                        dos.GetComponent<TextMeshPro>().text = vehiculos[i];
                    }
                    if (i == 2)
                    {
                        tres.GetComponent<TextMeshPro>().text = vehiculos[i];
                    }
                    if (i == 3)
                    {
                        cuatro.GetComponent<TextMeshPro>().text = vehiculos[i];
                    }
                    if (i == 4)
                    {
                        cinco.GetComponent<TextMeshPro>().text = vehiculos[i];
                    }
                    if (i == 5)
                    {
                        RandomList();
                    }
                }
                break;
            case 2:
                for (int i = 0; i < 6; i++)
                {

                    if (i == 0)
                    {
                        uno.GetComponent<TextMeshPro>().text = comida[i];
                    }
                    if (i == 1)
                    {
                        dos.GetComponent<TextMeshPro>().text = comida[i];
                    }
                    if (i == 2)
                    {
                        tres.GetComponent<TextMeshPro>().text = comida[i];
                    }
                    if (i == 3)
                    {
                        cuatro.GetComponent<TextMeshPro>().text = comida[i];
                    }
                    if (i == 4)
                    {
                        cinco.GetComponent<TextMeshPro>().text = comida[i];
                    }
                    if (i == 5)
                    {
                        RandomList();
                    }
                }
                break;
            case 3:
                for (int i = 0; i < 6; i++)
                {

                    if (i == 0)
                    {
                        uno.GetComponent<TextMeshPro>().text = deportes[i];
                    }
                    if (i == 1)
                    {
                        dos.GetComponent<TextMeshPro>().text = deportes[i];
                    }
                    if (i == 2)
                    {
                        tres.GetComponent<TextMeshPro>().text = deportes[i];
                    }
                    if (i == 3)
                    {
                        cuatro.GetComponent<TextMeshPro>().text = deportes[i];
                    }
                    if (i == 4)
                    {
                        cinco.GetComponent<TextMeshPro>().text = deportes[i];
                    }
                    if (i == 5)
                    {
                        RandomList();
                    }
                }
                break;
            case 4:
                for (int i = 0; i < 6; i++)
                {

                    if (i == 0)
                    {
                        uno.GetComponent<TextMeshPro>().text = colores[i];
                    }
                    if (i == 1)
                    {
                        dos.GetComponent<TextMeshPro>().text = colores[i];
                    }
                    if (i == 2)
                    {
                        tres.GetComponent<TextMeshPro>().text = colores[i];
                    }
                    if (i == 3)
                    {
                        cuatro.GetComponent<TextMeshPro>().text = colores[i];
                    }
                    if (i == 4)
                    {
                        cinco.GetComponent<TextMeshPro>().text = colores[i];
                    }
                    if (i == 5)
                    {
                        RandomList();
                    }
                }
                break;
            case 5:
                for (int i = 0; i < 6; i++)
                {

                    if (i == 0)
                    {
                        uno.GetComponent<TextMeshPro>().text = cocina[i];
                    }
                    if (i == 1)
                    {
                        dos.GetComponent<TextMeshPro>().text = cocina[i];
                    }
                    if (i == 2)
                    {
                        tres.GetComponent<TextMeshPro>().text = cocina[i];
                    }
                    if (i == 3)
                    {
                        cuatro.GetComponent<TextMeshPro>().text = cocina[i];
                    }
                    if (i == 4)
                    {
                        cinco.GetComponent<TextMeshPro>().text = cocina[i];
                    }
                    if (i == 5)
                    {
                        RandomList();
                    }
                }
                break;
            case 6:
                for (int i = 0; i < 6; i++)
                {

                    if (i == 0)
                    {
                        uno.GetComponent<TextMeshPro>().text = animales[i];
                    }
                    if (i == 1)
                    {
                        dos.GetComponent<TextMeshPro>().text = animales[i];
                    }
                    if (i == 2)
                    {
                        tres.GetComponent<TextMeshPro>().text = animales[i];
                    }
                    if (i == 3)
                    {
                        cuatro.GetComponent<TextMeshPro>().text = animales[i];
                    }
                    if (i == 4)
                    {
                        cinco.GetComponent<TextMeshPro>().text = animales[i];
                    }
                    if (i == 5)
                    {
                        RandomList();
                    }
                }
                break;
        }
    }

   
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.tag == "uno")
                    {
                        select = "uno";
                        StartCoroutine(cambio());
                    }
                    if (hit.transform.tag == "dos")
                    {
                        select = "dos";
                        StartCoroutine(cambio());
                    }
                    if (hit.transform.tag == "tres")
                    {
                        select = "tres";
                        StartCoroutine(cambio());
                    }
                    if (hit.transform.tag == "cuatro")
                    {
                        select = "cuatro";
                        StartCoroutine(cambio());
                    }
                    if (hit.transform.tag == "cinco")
                    {
                        select = "cinco";
                        StartCoroutine(cambio());
                    }
                    if (hit.transform.tag == "seis")
                    {
                        select = "seis";
                        StartCoroutine(cambio());
                    }
                }
        }

    }

    public IEnumerator cambio()
    {
        if (select == "seis")
        {
            GameObject.FindGameObjectWithTag(select).GetComponent<TextMeshPro>().color = Color.green;
            
                SceneManager.LoadScene("Escenario Blender");
            
        }
        else
        {
            GameObject.FindGameObjectWithTag(select).GetComponent<TextMeshPro>().color = Color.red;
            yield return new WaitForSeconds(1f);
            GameObject.FindGameObjectWithTag(select).GetComponent<TextMeshPro>().color = Color.black;

        }
    }      

    public void RandomList()
    {
        int rand = Random.Range(0,7);
        Debug.Log(rand);

        if (random!= rand)
        {
            switch (rand)
            {
                case 0:
                    seis.GetComponent<TextMeshPro>().text = familia[Random.Range(0,4)];
                    Debug.Log(familia[Random.Range(0, 4)]);
                    break;
                case 1:
                    seis.GetComponent<TextMeshPro>().text = vehiculos[Random.Range(0, 4)];
                    Debug.Log(vehiculos[Random.Range(0, 4)]);
                    break;
                case 2:
                    seis.GetComponent<TextMeshPro>().text = comida[Random.Range(0, 4)];
                    Debug.Log(comida[Random.Range(0, 4)]);
                    break;
                case 3:
                    seis.GetComponent<TextMeshPro>().text = deportes[Random.Range(0, 4)];
                    Debug.Log(deportes[Random.Range(0, 4)]);
                    break;
                case 4:
                    seis.GetComponent<TextMeshPro>().text = colores[Random.Range(0, 4)];
                    Debug.Log(colores[Random.Range(0, 4)]);
                    break;
                case 5:
                    seis.GetComponent<TextMeshPro>().text = cocina[Random.Range(0, 4)];
                    Debug.Log(cocina[Random.Range(0, 4)]);
                    break;
                case 6:
                    seis.GetComponent<TextMeshPro>().text = animales[Random.Range(0, 4)];
                    Debug.Log(animales[Random.Range(0, 4)]);
                    break;
            }
        }
        else
        {
            RandomList();
            Debug.Log("repite");
        }
    }


}
