using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Register : MonoBehaviour
{
    public InputField nameInput;
    public InputField emailInput;
    public InputField passwordInput;
    public InputField confirmpasswordInput;
    public Button registerButton;
    List<string> credentials;

    void Start()
    {
        registerButton.onClick.AddListener(WriteStuffToFile);

        if (File.Exists(Application.dataPath + "/données.txt"))
        {
            credentials = new List<string>(File.ReadAllLines(Application.dataPath + "/données.txt"));
        }
        else
        {
            File.WriteAllText(Application.dataPath + "/données.txt", "");
            credentials = new List<string>();
        }
    }

    void WriteStuffToFile()
    {
        bool isExists = false;

        // Check if username already exists in credentials file
        foreach (string line in credentials)
        {
            string[] parts = line.Split(':');
            if (parts[0].Equals(nameInput.text))
            {
                isExists = true;
                break;
            }
        }

        if (isExists)
        {
            Debug.Log($"The name '{nameInput.text}' exist");
        }
        else if (!passwordInput.text.Equals(confirmpasswordInput.text))
        {
            Debug.Log("Access denied");
        }
        else
        {
            // Add new user to credentials file
            string newLine = $"{nameInput.text}:{passwordInput.text}";
            credentials.Add(newLine);
            File.WriteAllLines(Application.dataPath + "/données.txt", credentials.ToArray());
            Debug.Log("Register successfuly");

            // Load the next scene
            SceneManager.LoadScene("Room of choice");
        }
    }
}
