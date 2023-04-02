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

    // Appel� lors du chargement de la sc�ne
    void Start()
    {
        registerButton.onClick.AddListener(SaveRegistration);
    }

    // Appel� lorsque le bouton "Register" est cliqu�
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

        // Cr�er un fichier d'inscription s'il n'existe pas d�j�
        string filePath = Application.dataPath + "/inscription.txt";
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Dispose();
        }

        // �crire les informations du formulaire dans le fichier d'inscription
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine("Nom : " + studentName);
            writer.WriteLine("Pr�nom : " + studentFirstName);
            writer.WriteLine("Date de naissance : " + dateOfBirth);
            writer.WriteLine("Adresse : " + address);
            writer.WriteLine("Code postal : " + postalCode);
            writer.WriteLine("Ville : " + city);
            writer.WriteLine("T�l�phone : " + phone);
            writer.WriteLine("Nom du parent : " + parentName);
            writer.WriteLine("T�l�phone du parent : " + parentPhone);
            writer.WriteLine("Niveau demand� : " + requestedGrade);
            writer.WriteLine("Ann�e scolaire : " + schoolYear);
            writer.WriteLine();

            writer.Close();
        }

        // Charger la nouvelle sc�ne
        SceneManager.LoadScene("Classe Room");
    }
}
