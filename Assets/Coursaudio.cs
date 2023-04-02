using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coursaudio : MonoBehaviour
{
    public AudioSource audioSource; // référence à l'AudioSource attaché à l'objet Book_B_Blue

    // Start est appelée avant la première frame
    void Start()
    {
        // Trouver l'objet Book_B_Blue dans la scène et récupérer son AudioSource
        GameObject bookBBlue = GameObject.Find("Book_B_Blue");
        audioSource = bookBBlue.GetComponent<AudioSource>();
    }

    // Cette fonction est appelée lorsqu'un clic est détecté sur un collider attaché à cet objet
    void OnMouseDown()
    {
        // Si l'AudioSource est présent et qu'il y a un clip attaché, jouer le clip
        if (audioSource && audioSource.clip)
        {
            audioSource.Play();
        }
    }
}
