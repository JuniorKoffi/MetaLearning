using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Choiceestablishment : MonoBehaviour
{
    public Dropdown select;

    // Cette méthode est appelée lors du démarrage de la scène
    void Start()
    {
        // Ajouter une méthode à appeler lorsqu'on change la sélection de la dropdown
        select.onValueChanged.AddListener(delegate { LoadNextPage(); });
    }

    // Cette méthode est appelée chaque fois que l'utilisateur change la sélection de la dropdown
    void LoadNextPage()
    {
        // Obtenez l'option sélectionnée
        string selectedOption = select.options[select.value].text;

        // Redirigez l'utilisateur en fonction de l'option sélectionnée
        switch (selectedOption)
        {
            case "Select":
                SceneManager.LoadScene("");
                break;
            case "ITL":
                SceneManager.LoadScene("Establishment registration form");
                break;
            case "Collège Jean":
                SceneManager.LoadScene("Establishment registration form");
                break;
            case "Lycée Louis":
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