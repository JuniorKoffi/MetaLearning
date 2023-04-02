using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{

    public InputField profilInput;
    public Button nextButton;

    // Start is called before the first frame update
    void Start()
    {
        nextButton.onClick.AddListener(goToNextScene);
    }

    void goToNextScene()
    {
        // Check if profil is valid
        if (profilInput.text.Equals("Student"))
        {
            SceneManager.LoadScene("Login Student");
        }
        else if (profilInput.text.Equals("Founder"))
        {
            SceneManager.LoadScene("Login Founder");
        }
        else if (profilInput.text.Equals("Learner"))
        {
            SceneManager.LoadScene("Login Learner");
        }
        else
        {
            Debug.Log($"Invalid profil '{profilInput.text}'. Please enter 'Student', 'Founder' or 'Learner'.");
        }
    }
}
