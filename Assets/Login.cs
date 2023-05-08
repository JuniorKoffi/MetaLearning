using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{

    public Button loginButton;
    public Button gotoregisterButton;

    // Start is called before the first frame update
    void Start()
    {
        loginButton.onClick.AddListener(loadWelcomeScreen);
        gotoregisterButton.onClick.AddListener(moveToRegister);
    }

    void moveToRegister()
    {
        SceneManager.LoadScene("Room of inscription");
    }

    void loadWelcomeScreen()
    {
        SceneManager.LoadScene("Room of choice");
    }
}
