using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Choiceofestablishement2 : MonoBehaviour
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
            case "Acad�mie de Conduite du Plateau":
                SceneManager.LoadScene("Driving school registration form");
                break;
            case "�cole de Conduite 2000":
                SceneManager.LoadScene("Driving school registration form");
                break;
            case "Acad�mie de Conduite Trans-Qu�bec":
                SceneManager.LoadScene("Driving school registration form");
                break;
            default:
                Debug.LogError("Option de dropdown invalide : " + selectedOption);
                break;
        }
    }
}
