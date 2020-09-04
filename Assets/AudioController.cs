using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

    public AudioSource audioSource;
    public float AudioTimeNow = 0.0f;
    public float AudioFullLength;
    public bool Stop = false;
    private AudioClip audioClip;

    void Start () {
        if(!audioSource){
            Debug.LogWarning("AudioSourceがセットされていません");
            return;
        }
        if(!audioSource.clip){
            Debug.LogWarning("AudioClipがセットされていません");
            return;
        }
        audioClip = audioSource.clip;
        AudioFullLength = audioClip.length;
    }

    void Update () {
        if(!audioSource){
            Debug.LogWarning("AudioSourceがセットされていません");
            return;
        }
        if(Stop){
            if(audioSource.isPlaying){
                audioSource.Pause();
            }
            return;
        }else{
            if(!audioSource.isPlaying){
                audioSource.UnPause();
            }
        }
        AudioTimeNow = audioSource.time;
    }

    private void OnValidate(){
        audioSource.time = AudioTimeNow;
    }
}