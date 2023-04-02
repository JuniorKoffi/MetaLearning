using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loginfounder : MonoBehaviour
{

    public Button loginButton;
    public Button goToRegisterButton;

    // Start is called before the first frame update
    void Start()
    {
        loginButton.onClick.AddListener(loadWelcomeScreen);
        goToRegisterButton.onClick.AddListener(moveToRegister);
    }

    void moveToRegister()
    {
        SceneManager.LoadScene("Register Founder");
    }

    void loadWelcomeScreen()
    {
        SceneManager.LoadScene("Bureau");
    }
}
