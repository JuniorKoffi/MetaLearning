using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Choiceofestablishement : MonoBehaviour
{
    public Dropdown dropdown;

    // Cette méthode est appelée lors du démarrage de la scène
    void Start()
    {
        // Ajouter une méthode à appeler lorsqu'on change la sélection de la dropdown
        dropdown.onValueChanged.AddListener(delegate { LoadNextPage(); });
    }

    // Cette méthode est appelée chaque fois que l'utilisateur change la sélection de la dropdown
    void LoadNextPage()
    {
        // Obtenez l'option sélectionnée
        string selectedOption = dropdown.options[dropdown.value].text;

        // Redirigez l'utilisateur en fonction de l'option sélectionnée
        switch (selectedOption)
        {
            case "Collège Divine Providence":
                SceneManager.LoadScene("College registration form");
                break;
            case "Collège Mr Pierre Pango":
                SceneManager.LoadScene("College registration form");
                break;
            case "Collège Mr Kirman":
                SceneManager.LoadScene("College registration form");
                break;
            default:
                Debug.LogError("Option de dropdown invalide : " + selectedOption);
                break;
        }
    }
}
