using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Audio;
public class AudioManager : MonoBehaviour
{
    // ƒ‰nil‰hteet sis‰lt‰v‰ oliotalukko:
    public Sound[] sounds;

    // Singelton:
    public static AudioManager instance;

    public string currentMusic;


    private void Awake()
    {
        if (instance == null)
            instance = this;
        
        else
        {
            // Audiomanager on jo olemassa, joten tuhotaan se:
            Destroy(gameObject);
            // Varmistetaan ett‰ muuta koodia ei en‰‰n suoriteta:
            return;


        }
        // ƒl‰ tuhoaa GameObjektia ladattaessa:
        DontDestroyOnLoad(gameObject);
        
        // N‰ytt‰‰ oliotaulukon kaikki l‰hteet:
        foreach (Sound s in sounds)
        {
            // Yhteys ‰‰nil‰hteeseen:
            s.source = gameObject.AddComponent<AudioSource>();

            // ƒ‰ni, joka halutaan soittaa:
            s.source.clip = s.clip;

            // P‰ivitt‰‰ tehdyt s‰‰dˆt Audio-komponenttiin.
            s.source.volume = s.volume; // Voimakkuus
            s.source.pitch = s.pitch;
            s.source.loop = s.loop; // Soitetaanko luupissa

        }
    }


    public void Start()
    {
        // Oletusmusiikki:
        Play("Menu");
    }

    // Soittaa halutun ‰‰nen:
    public void Play(string name)
    {
        // Etsit‰‰n haluttu ‰‰ni:
        Sound s = Array.Find(sounds, sound => sound.name == name);
        // Onko ‰‰nt‰ olemassa?
        if (s == null)
            // Ei ole, joten muutetaan metodista pois:
            return;
            // Soitetaan ‰‰ni
            s.source.Play();

        
    }

    // Pys‰ytt‰‰ halutun ‰‰nen:
    public void StopPlay(string name)
    {
        // Etsit‰‰n haluttu ‰‰ni:
        Sound s = Array.Find(sounds, sound => sound.name == name);

        // Onko ‰‰nt‰ olemassa?
        if (s == null)
            // Ei ole, joten hyp‰t‰‰n metodista pois:
            return;
            // Pys‰ytet‰‰n ‰‰ni:
            s.source.Stop();
        
    }
}
