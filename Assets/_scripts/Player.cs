using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    //spawn
    [SerializeField] GameObject spawnPoints;
    [SerializeField] public bool respawn = false;
    private Transform[] spawnPointsList;

    private Helicopter helicopter;
    private ClearArea clearArea;

	void Start ()
    {
        spawnPointsList = spawnPoints.GetComponentsInChildren<Transform>();
        helicopter = FindObjectOfType<Helicopter>();
        clearArea = GetComponentInChildren<ClearArea>();
        ReSpawn();
    }


    void Update ()
    {
        CheckReSpawn();
        CheckCallHelicopter();
    }

    private void ReSpawn()
    {
        int index = Random.Range(0, spawnPointsList.Length); //max value is exclusive
        gameObject.transform.position = spawnPointsList[index].position;

    }


    private void CheckCallHelicopter()
    {
        if (Input.GetButton("Helicopter"))
        {
            if (clearArea.isClear){
                SendMessageUpwards("OnMakeInitialHeliCall");
                //TODO:deploy flare
            }

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

    private void NotifyAreaIsClear(){
        BroadcastMessage("OnFindClearArea");
    }


}
