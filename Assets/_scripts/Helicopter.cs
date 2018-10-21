using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

    private bool called = false;
    private AudioSource audioSource;
    private Rigidbody rigidbody;


	void Start () {
        audioSource = GetComponent<AudioSource>();
        rigidbody = GetComponent<Rigidbody>();
	}
	

    void OnDispatchHelicopter()
    {
        if (!called)
        {
            called = true;
            audioSource.Play();
            rigidbody.velocity = new Vector3(0, 0, 50f);
        }
    }
}
