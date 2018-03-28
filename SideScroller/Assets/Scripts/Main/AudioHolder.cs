using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHolder : MonoBehaviour {

    public AudioClip bgm1;
    public AudioSource MusicSource;
    public Collider Trigger1;
    private bool hasTriggered1 = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !hasTriggered1)
        {
            Debug.Log("Enter1");
            MusicSource.clip = bgm1;
            MusicSource.Play();

            
                hasTriggered1 = true;
        }

    }
}
