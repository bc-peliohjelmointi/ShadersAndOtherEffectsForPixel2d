using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]  // Näkyy inspektorissa

public class Sound
{
    // Ääni:
    public AudioClip clip;

    // Äänen nimi
    public string name;

    // Liukukytkimet 
    [Range(0f, 1f)]
    public float volume;  // Voimakkuus: 0-1

    [Range(0.1f, 3f)]
    public float pitch;    // Sävelkorkeus: 0.1-3

    // Kertoo, soitetaanko ääni loopissa
    public bool loop;

    // Äänen lähde, joka piilotetaan:
    [HideInInspector]
    public AudioSource source; // Audiomanager -luokka käyttää tätä muuttujaa 



}
