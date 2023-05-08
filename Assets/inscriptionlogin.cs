using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class inscriptionlogin : MonoBehaviour
{

    public Button gotologinButton;

    // Start is called before the first frame update
    void Start()
    {
        gotologinButton.onClick.AddListener(goToNextScene);
    }

    void goToNextScene()
    {

        SceneManager.LoadScene("Room of connexion");


    }
}