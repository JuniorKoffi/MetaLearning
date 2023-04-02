using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Choiceofestablishement : MonoBehaviour
{
    public Dropdown dropdown;

    // Cette m�thode est appel�e lors du d�marrage de la sc�ne
    void Start()
    {
        // Ajouter une m�thode � appeler lorsqu'on change la s�lection de la dropdown
        dropdown.onValueChanged.AddListener(delegate { LoadNextPage(); });
    }

    // Cette m�thode est appel�e chaque fois que l'utilisateur change la s�lection de la dropdown
    void LoadNextPage()
    {
        // Obtenez l'option s�lectionn�e
        string selectedOption = dropdown.options[dropdown.value].text;

        // Redirigez l'utilisateur en fonction de l'option s�lectionn�e
        switch (selectedOption)
        {
            case "Coll�ge Divine Providence":
                SceneManager.LoadScene("College registration form");
                break;
            case "Coll�ge Mr Pierre Pango":
                SceneManager.LoadScene("College registration form");
                break;
            case "Coll�ge Mr Kirman":
                SceneManager.LoadScene("College registration form");
                break;
            default:
                Debug.LogError("Option de dropdown invalide : " + selectedOption);
                break;
        }
    }
}
