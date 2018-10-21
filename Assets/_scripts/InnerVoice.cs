using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerVoice : MonoBehaviour {

    AudioSource audioSource;

    [SerializeField] AudioClip areaIsClearSound;
    [SerializeField] AudioClip whatHappenedSound;

    void Start () {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = whatHappenedSound;
        audioSource.Play();
	}
	
    void OnFindClearArea(){
        print(name + " OnFindClearArea");
        audioSource.clip = areaIsClearSound;
        audioSource.Play();
    }

    //void OnCallHelicopter(){
    //    print(name + " OnCallHelicopter");
    //    audioSource.clip = callHelipterSound;
    //    audioSource.Play();
    //}
}
