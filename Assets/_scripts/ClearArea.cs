using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearArea : MonoBehaviour {
    [SerializeField] float clearDelay = 3f;
    private BoxCollider clearAreaCollider;
    //private Player parentPlayer;
    private float lastCollisionTime;
    public bool isClear;

    void Start () {
        clearAreaCollider = GetComponentInChildren<BoxCollider>();
        //parentPlayer = GetComponentInParent<Player>();
    }

    void Update () {
        if(Time.time >= lastCollisionTime + clearDelay)
        {
            if(!isClear){
                isClear = true;
                //parentPlayer.NotifyAreaIsClear();
                SendMessageUpwards("NotifyAreaIsClear");
            }
        } else {
            isClear = false;
        }
	}

    private void OnTriggerStay(Collider other)
    {
        if(other.tag != "Player")
            lastCollisionTime = Time.time;
    }

}
