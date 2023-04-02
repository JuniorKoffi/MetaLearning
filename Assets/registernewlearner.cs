using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class registernewlearner : MonoBehaviour
{
    public InputField firstNameInput;
    public InputField lastNameInput;
    public InputField dateOfBirthInput;
    public InputField addressInput;
    public InputField postalCodeInput;
    public InputField cityInput;
    public InputField phoneInput;
    public InputField trainingTypeInput;
    public InputField startDateInput;
    public Button registerButton;

    private string filePath;

    // Start is called before the first frame update
    void Start()
    {
        // Get the file path of the registration file
        filePath = Application.dataPath + "/inscription_learner.csv";

        // Add an onClick listener to the register button
        registerButton.onClick.AddListener(RegisterLearner);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RegisterLearner()
    {
        // Create a new line of data for the registration file
        string[] data = new string[] {
            firstNameInput.text,
            lastNameInput.text,
            dateOfBirthInput.text,
            addressInput.text,
            postalCodeInput.text,
            cityInput.text,
            phoneInput.text,
            trainingTypeInput.text,
            startDateInput.text
        };

        // Write the data to the registration file
        using (StreamWriter sw = File.AppendText(filePath))
        {
            sw.WriteLine(string.Join(",", data));
        }

        // Load the new scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("Classe Room Learner");
    }
}
