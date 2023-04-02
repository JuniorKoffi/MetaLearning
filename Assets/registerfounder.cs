using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class registerfounder : MonoBehaviour
{
    public InputField usernameInput;
    public InputField passwordInput;
    public InputField confirmPasswordInput;
    public Button registerButton;
    public Button returnButton;

    List<string> credentials;

    void Start()
    {
        registerButton.onClick.AddListener(WriteStuffToFile);
        returnButton.onClick.AddListener(ReturnScene);

        if (File.Exists(Application.dataPath + "/credentials.txt"))
        {
            credentials = new List<string>(File.ReadAllLines(Application.dataPath + "/credentials.txt"));
        }
        else
        {
            File.WriteAllText(Application.dataPath + "/credentials.txt", "");
            credentials = new List<string>();
        }
    }

    void ReturnScene()
    {
        SceneManager.LoadScene("welcome");
    }

    void WriteStuffToFile()
    {
        bool isExists = false;

        // Check if username already exists in credentials file
        foreach (string line in credentials)
        {
            string[] parts = line.Split(':');
            if (parts[0].Equals(usernameInput.text))
            {
                isExists = true;
                break;
            }
        }

        if (isExists)
        {
            Debug.Log($"Username '{usernameInput.text}' already exists");
        }
        else if (!passwordInput.text.Equals(confirmPasswordInput.text))
        {
            Debug.Log("Passwords do not match");
        }
        else
        {
            // Add new user to credentials file
            string newLine = $"{usernameInput.text}:{passwordInput.text}";
            credentials.Add(newLine);
            File.WriteAllLines(Application.dataPath + "/credentials.txt", credentials.ToArray());
            Debug.Log("Account Registered");

            // Load the next scene
            SceneManager.LoadScene("Login Founder");
        }
    }
}
