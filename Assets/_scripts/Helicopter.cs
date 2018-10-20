using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

    private bool called = true;
    private AudioSource audioSource;


	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        CheckCallHelicopter();
	}

    private void CheckCallHelicopter()
    {
        if (Input.GetButton("Helicopter"))
        {
            called = true;
            audioSource.Play();
        }
    }
}
