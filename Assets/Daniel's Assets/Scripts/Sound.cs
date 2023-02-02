using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]  // N�kyy inspektorissa

public class Sound
{
    // ��ni:
    public AudioClip clip;

    // ��nen nimi
    public string name;

    // Liukukytkimet 
    [Range(0f, 1f)]
    public float volume;  // Voimakkuus: 0-1

    [Range(0.1f, 3f)]
    public float pitch;    // S�velkorkeus: 0.1-3

    // Kertoo, soitetaanko ��ni loopissa
    public bool loop;

    // ��nen l�hde, joka piilotetaan:
    [HideInInspector]
    public AudioSource source; // Audiomanager -luokka k�ytt�� t�t� muuttujaa 



}
