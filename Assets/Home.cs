using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{

    public Button getstartedButton;

    // Start is called before the first frame update
    void Start()
    {
        getstartedButton.onClick.AddListener(goToNextScene);
    }

    void goToNextScene()
    {
       
            SceneManager.LoadScene("Room of inscription");

        
    }
}