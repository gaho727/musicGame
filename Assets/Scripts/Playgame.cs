using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playgame : MonoBehaviour
{
    private AudioClip[] audioClips;
    public new AudioSource audio;
    int num = 0;

    public void SetAudioClips(AudioClip[] audios)
	{
        audioClips = audios;
	}

    public void PlayMusic()
	{
        audio.clip = audioClips[num++];
        audio.Play();
    }

    public void StopMusic()
	{
        audio.Stop();
	}

    public int getAudioClips()
	{
        return audioClips.Length;
	}

    public void ResetGame()
	{
        num = 0;
	}
}
