using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class establishmentform : MonoBehaviour
{

    public Button submitButton;

    // Start is called before the first frame update
    void Start()
    {
        submitButton.onClick.AddListener(goToNextScene);
    }

    void goToNextScene()
    {

        SceneManager.LoadScene("payment room");


    }
}