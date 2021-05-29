using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogSystem : MonoBehaviour
{

    public Text nombreTexto;
    public Text dialogueTexto;

    public Animator animator;

    private Queue<string> frases;

    // Start is called before the first frame update
    void Start()
    {
        frases = new Queue<string>();
    }

    public void StartDialogue (Dialogos D)
    {
        animator.SetBool("IsOpen", true);
        Debug.Log ("conversacion con " + D.nombre);
        nombreTexto.text = D.nombre;

        frases.Clear();

        foreach(string frase in D.frases)
        {
            frases.Enqueue(frase);
        }

        DisplayNextFrase();
    }

    public void DisplayNextFrase()
    {
        if (frases.Count == 0)
        {
            EndDialogue();
            return;
        }

        string frase = frases.Dequeue();
        StopAllCoroutines();
        StartCoroutine(Escitura(frase));
    }
  
    IEnumerator Escitura (string frase)
    {
        dialogueTexto.text = "";
        foreach (char letter in frase.ToCharArray())
        {
            dialogueTexto.text += letter;
            yield return null;
        }
    }
    public void EndDialogue()
    {
        Debug.Log("final");
        animator.SetBool("IsOpen", false);
    }
}
