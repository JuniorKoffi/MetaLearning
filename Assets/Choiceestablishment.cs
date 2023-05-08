using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Choiceestablishment : MonoBehaviour
{
    public Dropdown select;

    // Cette m�thode est appel�e lors du d�marrage de la sc�ne
    void Start()
    {
        // Ajouter une m�thode � appeler lorsqu'on change la s�lection de la dropdown
        select.onValueChanged.AddListener(delegate { LoadNextPage(); });
    }

    // Cette m�thode est appel�e chaque fois que l'utilisateur change la s�lection de la dropdown
    void LoadNextPage()
    {
        // Obtenez l'option s�lectionn�e
        string selectedOption = select.options[select.value].text;

        // Redirigez l'utilisateur en fonction de l'option s�lectionn�e
        switch (selectedOption)
        {
            case "Select":
                SceneManager.LoadScene("");
                break;
            case "ITL":
                SceneManager.LoadScene("Establishment registration form");
                break;
            case "Coll�ge Jean":
                SceneManager.LoadScene("Establishment registration form");
                break;
            case "Lyc�e Louis":
                SceneManager.LoadScene("Establishment registration form");
                break;
            case "Ecole des Arts":
                SceneManager.LoadScene("Establishment registration form");
                break;
            default:
                Debug.LogError("Option de dropdown invalide : " + selectedOption);
                break;
        }
    }
}