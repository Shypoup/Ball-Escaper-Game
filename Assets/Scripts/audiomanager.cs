using UnityEngine.Audio;
using UnityEngine;
using System;
public class audiomanager : MonoBehaviour
{


    public sound[] sounds;
    public static audiomanager instance;

    // Start is called before the first frame update
    void Awake ()
    {
        if( instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        foreach(sound s in sounds)
        {
          s.source =  gameObject.AddComponent<AudioSource>();
          s.source.clip = s.Clip;
          s.source.volume = s.volume;
          s.source.pitch = s.pitch;
          s.source.loop = s.loop;
        }
    }

    void start()
    {
        play("theme");
    }
     public void play (string name)
    {
     sound s =  Array.Find(sounds, sound => sound.name == name);
     if (s == null)
     {
         Debug.LogWarning("sound: " + name + "not found");
         return;
     }
     s.source.Play();
    }
}
