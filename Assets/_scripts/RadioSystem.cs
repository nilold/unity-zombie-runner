using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSystem : MonoBehaviour {

    AudioSource audioSource;

    [SerializeField] AudioClip heliCall;
    [SerializeField] AudioClip heliCallReply;

	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
    void OnMakeInitialHeliCall(){
        audioSource.clip = heliCall;
        audioSource.Play();
        Invoke("HeliReply", heliCall.length + 1f);
    }

    void HeliReply(){
        audioSource.clip = heliCallReply;
        audioSource.Play();
        BroadcastMessage("OnDispatchHelicopter");
    }

}
