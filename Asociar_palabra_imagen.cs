using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Asociar_palabra_imagen : MonoBehaviour
{
    public int level ;

    public GameObject[] sprite= new GameObject[20];

    public GameObject[] palabrasBox = new GameObject[20];

    public List<string> palabras = new List<string>();
    public List<string> check = new List<string>();


    public int checkThat = 0;

    void Awake()
    {
        palabras.Add("agua");
        palabras.Add("antena");
        palabras.Add("bicicleta");
        palabras.Add("botella");
        palabras.Add("cafe");
        palabras.Add("canasta");
        palabras.Add("casa");
        palabras.Add("coche");
        palabras.Add("cuchara");
        palabras.Add("cuchillo");
        palabras.Add("edificio");
        palabras.Add("monopatin");
        palabras.Add("moto");
        palabras.Add("motor");
        palabras.Add("navaja");
        palabras.Add("pan");
        palabras.Add("patinete");
        palabras.Add("pelota");
        palabras.Add("puerta");
        palabras.Add("retrovisor");
        palabras.Add("rueda");
        palabras.Add("tenedor");
        palabras.Add("ventana");

        check.Add("");
        check.Add("");
        check.Add("");
        check.Add("");
        check.Add("");
        check.Add("");
        check.Add("");
        check.Add("");

        check.Add("");
    }
    // Start is called before the first frame update
    void Start()
    {
        switch (level)
        {

            case 1:

                for (int i = 0; i < 2; i++)
                {
                    string selec = palabras[Random.Range(0, palabras.Count)];
                    Sprite spriteS = Resources.Load<Sprite>("Images/" + selec) as Sprite;
                    int randomizer = Random.Range(0,19);
                    if (i == 0)
                    {
                        sprite[6].GetComponent<SpriteRenderer>().sprite = spriteS;
                        sprite[6].GetComponent<SpriteRenderer>().size = new Vector2(2.75f,1.83f);
                        sprite[6].gameObject.tag = selec;

                        palabrasBox[randomizer].GetComponent<TextMeshPro>().text = selec;
                        palabrasBox[randomizer].gameObject.tag = selec;
                    }
                    if (i == 1)
                    {
                        sprite[8].GetComponent<SpriteRenderer>().sprite = spriteS;
                        sprite[8].GetComponent<SpriteRenderer>().size = new Vector2(2.75f, 1.83f);
                        sprite[8].gameObject.tag = selec;

                        palabrasBox[randomizer].GetComponent<TextMeshPro>().text = selec;
                        palabrasBox[randomizer].gameObject.tag = selec;
                    }

                }
                break;

            case 4:

               
                for (int i = 0; i < 7; i++)
                {
                    string selec = palabras[Random.Range(0, palabras.Count)];
                    Sprite spriteS = Resources.Load<Sprite>("Images/" + selec) as Sprite;
                    int randomizer = Random.Range(0, 19);

                    if (i == 0)
                    {
                        sprite[6].GetComponent<SpriteRenderer>().sprite = spriteS;
                        sprite[6].GetComponent<SpriteRenderer>().size = new Vector2(2.75f, 1.83f);
                        sprite[6].gameObject.tag = selec;

                        if (palabrasBox[randomizer].GetComponent<TextMeshPro>().text == "")
                        {
                            palabrasBox[randomizer].GetComponent<TextMeshPro>().text = selec;
                            palabrasBox[randomizer].gameObject.tag = selec;
                            check[1] = selec;
                        }
                        else
                        {
                            while (palabrasBox[randomizer].GetComponent<TextMeshPro>().text != "")
                            {
                                if (randomizer >= 20)
                                {
                                    randomizer = randomizer - 10;
                                }
                                else
                                {
                                    randomizer = randomizer + 1;

                                }

                            }

                            print("hey0");
                            palabrasBox[randomizer].GetComponent<TextMeshPro>().text = selec;
                            palabrasBox[randomizer].gameObject.tag = selec;
                            //palabrasBox[randomizer].gameObject.tag = "Untagged";
                        }

                    }
                    if (i == 1)
                    {
                        sprite[8].GetComponent<SpriteRenderer>().sprite = spriteS;
                        sprite[8].GetComponent<SpriteRenderer>().size = new Vector2(2.75f, 1.83f);
                        sprite[8].gameObject.tag = selec;

                        if (palabrasBox[randomizer].GetComponent<TextMeshPro>().text == "")
                        {
                            palabrasBox[randomizer].GetComponent<TextMeshPro>().text = selec;
                            palabrasBox[randomizer].gameObject.tag = selec;
                            check[2] = selec;
                        }
                        else
                        {
                            while (palabrasBox[randomizer].GetComponent<TextMeshPro>().text != "")
                            {
                                if (randomizer >= 20)
                                {
                                    randomizer = randomizer - 10;
                                }
                                else
                                {
                                    randomizer = randomizer + 1;

                                }

                            }

                            print("hey1");
                            palabrasBox[randomizer].GetComponent<TextMeshPro>().text = selec;
                            palabrasBox[randomizer].gameObject.tag = selec;
                            //palabrasBox[randomizer].gameObject.tag = "Untagged";;
                        }
                    }
                    if (i == 2)
                    {
                        sprite[11].GetComponent<SpriteRenderer>().sprite = spriteS;
                        sprite[11].GetComponent<SpriteRenderer>().size = new Vector2(2.75f, 1.83f);
                        sprite[11].gameObject.tag = selec;

                        if (palabrasBox[randomizer].GetComponent<TextMeshPro>().text == "")
                        {
                            palabrasBox[randomizer].GetComponent<TextMeshPro>().text = selec;
                            palabrasBox[randomizer].gameObject.tag = selec;
                            check[3] = selec;
                        }
                        else
                        {
                            while (palabrasBox[randomizer].GetComponent<TextMeshPro>().text != "")
                            {
                                if (randomizer >= 20)
                                {
                                    randomizer = randomizer - 10;
                                }
                                else
                                {
                                    randomizer = randomizer + 1;

                                }

                            }

                            print("hey2");
                            palabrasBox[randomizer].GetComponent<TextMeshPro>().text = selec;
                            palabrasBox[randomizer].gameObject.tag = selec;
                            //palabrasBox[randomizer].gameObject.tag = "Untagged";
                        }
                    }

                    if (i == 3)
                    {
                        sprite[7].GetComponent<SpriteRenderer>().sprite = spriteS;
                        sprite[7].GetComponent<SpriteRenderer>().size = new Vector2(2.75f, 1.83f);
                        sprite[7].gameObject.tag = selec;

                        if (palabrasBox[randomizer].GetComponent<TextMeshPro>().text == "")
                        {
                            palabrasBox[randomizer].GetComponent<TextMeshPro>().text = selec;
                            palabrasBox[randomizer].gameObject.tag = selec;
                            check[6] = selec;
                        }
                        else
                        {
                            while (palabrasBox[randomizer].GetComponent<TextMeshPro>().text != "")
                            {
                                if (randomizer >= 20)
                                {
                                    randomizer = randomizer - 10;
                                }
                                else
                                {
                                    randomizer = randomizer + 1;

                                }

                            }

                            print("hey3");
                            palabrasBox[randomizer].GetComponent<TextMeshPro>().text = selec;
                            palabrasBox[randomizer].gameObject.tag = selec;
                            //palabrasBox[randomizer].gameObject.tag = "Untagged";
                        }
                    }
                    if (i == 4)
                    {
                        sprite[12].GetComponent<SpriteRenderer>().sprite = spriteS;
                        sprite[12].GetComponent<SpriteRenderer>().size = new Vector2(2.75f, 1.83f);
                        sprite[12].gameObject.tag = selec;

                        if (palabrasBox[randomizer].GetComponent<TextMeshPro>().text == "")
                        {
                            palabrasBox[randomizer].GetComponent<TextMeshPro>().text = selec;
                            palabrasBox[randomizer].gameObject.tag = selec;
                            check[4] = selec;
                        }
                        else
                        {
                            while (palabrasBox[randomizer].GetComponent<TextMeshPro>().text != "")
                            {
                                if (randomizer >= 20)
                                {
                                    randomizer = randomizer - 10;
                                }
                                else
                                {
                                    randomizer = randomizer + 1;

                                }

                            }

                            print("hey4");
                            palabrasBox[randomizer].GetComponent<TextMeshPro>().text = selec;
                            palabrasBox[randomizer].gameObject.tag = selec;
                            //palabrasBox[randomizer].gameObject.tag = "Untagged";
                        }
                    }
                    if (i == 5)
                    {
                        sprite[13].GetComponent<SpriteRenderer>().sprite = spriteS;
                        sprite[13].GetComponent<SpriteRenderer>().size = new Vector2(2.75f, 1.83f);
                        sprite[13].gameObject.tag = selec;

                        if (palabrasBox[randomizer].GetComponent<TextMeshPro>().text == "")
                        {
                            palabrasBox[randomizer].GetComponent<TextMeshPro>().text = selec;
                            palabrasBox[randomizer].gameObject.tag = selec;
                            check[5] = selec;
                        }
                        else
                        {
                            while (palabrasBox[randomizer].GetComponent<TextMeshPro>().text != "")
                            {
                                if (randomizer >= 20)
                                {
                                    randomizer = randomizer - 10;
                                }
                                else
                                {
                                    randomizer = randomizer+1;

                                }

                            }

                            print("hey5");
                            palabrasBox[randomizer].GetComponent<TextMeshPro>().text = selec;
                            palabrasBox[randomizer].gameObject.tag = selec;
                            //palabrasBox[randomizer].gameObject.tag = "Untagged";
                        }
                    }

                    if (i == 6)
                    {
                        for (int y = 1; y < check.Count; y++)
                        {
                            print(check[y]);
                        }
                        if (check[1]==check[2] || check[1] == check[3] || check[1] == check[4] || check[1] == check[5] || check[1] == check[6] || check[2] == check[3] || check[2] == check[4] || check[2] == check[5] || check[2] == check[6] || check[3] == check[4] || check[3] == check[5] || check[3] == check[6] || check[4] == check[5] || check[4] == check[6] || check[6] == check[5])
                        {
                            i = -1;
                            print("hey");
                            for (int x = 0; x < palabrasBox.Length; x++)
                            {
                                palabrasBox[x].GetComponent<TextMeshPro>().text = "";
                            }
                        }

                    }
                }
                    break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
        switch (level)
        {
            case 1:
                if (checkThat == 2)
                {
                    print("ganado");
                    SceneManager.LoadScene("Escenario Blender");

                }


                break;

            case 4:
                if (checkThat == 6)
                {
                    print("ganado");
                    SceneManager.LoadScene("Escenario Blender");

                }

                break;
        }
    }
}
