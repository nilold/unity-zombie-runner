using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField] GameObject spawnPoints;
    [SerializeField] public bool respawn = false;
    private Transform[] spawnPointsList;

    private AudioSource audioSource;

    [SerializeField] AudioClip callHelipterSound;

    private void ReSpawn(){
        int index = Random.Range(0, spawnPointsList.Length); //max value is exclusive
        gameObject.transform.position = spawnPointsList[index].position;
    }

	void Start () {
        audioSource = GetComponent<AudioSource>();
        spawnPointsList = spawnPoints.GetComponentsInChildren<Transform>();
        ReSpawn();
	}
	
	void Update ()
    {
        CheckReSpawn();
        if(Input.GetButton("Helicopter")){
            audioSource.PlayOneShot(callHelipterSound);
        }
    }

    private void CheckReSpawn()
    {
        if (respawn)
        {
            ReSpawn();
            respawn = false;
        }
    }
}
