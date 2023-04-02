using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Choiceofestablishement2 : MonoBehaviour
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
            case "Académie de Conduite du Plateau":
                SceneManager.LoadScene("Driving school registration form");
                break;
            case "École de Conduite 2000":
                SceneManager.LoadScene("Driving school registration form");
                break;
            case "Académie de Conduite Trans-Québec":
                SceneManager.LoadScene("Driving school registration form");
                break;
            default:
                Debug.LogError("Option de dropdown invalide : " + selectedOption);
                break;
        }
    }
}
