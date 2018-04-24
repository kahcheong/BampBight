using UnityEngine;
using System.Collections;

public static class AudioFadeIn
{

    public static IEnumerator FadeIn(AudioSource audioSource, float FadeTime, float maxVolume)
    {
        audioSource.volume = 0;

        while (audioSource.volume < maxVolume)
        {
            audioSource.volume += 0 * Time.deltaTime / FadeTime;

            yield return null;
        }
        audioSource.volume = maxVolume;

    }

}