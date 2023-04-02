using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coursaudio : MonoBehaviour
{
    public AudioSource audioSource; // r�f�rence � l'AudioSource attach� � l'objet Book_B_Blue

    // Start est appel�e avant la premi�re frame
    void Start()
    {
        // Trouver l'objet Book_B_Blue dans la sc�ne et r�cup�rer son AudioSource
        GameObject bookBBlue = GameObject.Find("Book_B_Blue");
        audioSource = bookBBlue.GetComponent<AudioSource>();
    }

    // Cette fonction est appel�e lorsqu'un clic est d�tect� sur un collider attach� � cet objet
    void OnMouseDown()
    {
        // Si l'AudioSource est pr�sent et qu'il y a un clip attach�, jouer le clip
        if (audioSource && audioSource.clip)
        {
            audioSource.Play();
        }
    }
}
