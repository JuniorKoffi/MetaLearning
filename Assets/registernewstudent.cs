using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class registernewstudent : MonoBehaviour
{
    public InputField studentNameInput;
    public InputField studentFirstNameInput;
    public InputField dateOfBirthInput;
    public InputField addressInput;
    public InputField postalCodeInput;
    public InputField cityInput;
    public InputField phoneInput;
    public InputField parentNameInput;
    public InputField parentPhoneInput;
    public InputField requestedGradeInput;
    public InputField schoolYearInput;

    public Button registerButton;

    // Appelé lors du chargement de la scène
    void Start()
    {
        registerButton.onClick.AddListener(SaveRegistration);
    }

    // Appelé lorsque le bouton "Register" est cliqué
    public void SaveRegistration()
    {
        string studentName = studentNameInput.text;
        string studentFirstName = studentFirstNameInput.text;
        string dateOfBirth = dateOfBirthInput.text;
        string address = addressInput.text;
        string postalCode = postalCodeInput.text;
        string city = cityInput.text;
        string phone = phoneInput.text;
        string parentName = parentNameInput.text;
        string parentPhone = parentPhoneInput.text;
        string requestedGrade = requestedGradeInput.text;
        string schoolYear = schoolYearInput.text;

        // Créer un fichier d'inscription s'il n'existe pas déjà
        string filePath = Application.dataPath + "/inscription.txt";
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Dispose();
        }

        // Écrire les informations du formulaire dans le fichier d'inscription
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine("Nom : " + studentName);
            writer.WriteLine("Prénom : " + studentFirstName);
            writer.WriteLine("Date de naissance : " + dateOfBirth);
            writer.WriteLine("Adresse : " + address);
            writer.WriteLine("Code postal : " + postalCode);
            writer.WriteLine("Ville : " + city);
            writer.WriteLine("Téléphone : " + phone);
            writer.WriteLine("Nom du parent : " + parentName);
            writer.WriteLine("Téléphone du parent : " + parentPhone);
            writer.WriteLine("Niveau demandé : " + requestedGrade);
            writer.WriteLine("Année scolaire : " + schoolYear);
            writer.WriteLine();

            writer.Close();
        }

        // Charger la nouvelle scène
        SceneManager.LoadScene("Classe Room");
    }
}
