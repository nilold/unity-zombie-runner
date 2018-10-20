using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour {

    [Tooltip("Number of minutes per second, hint: 60")]
    [SerializeField] float timeScale = 60f; //minutes por second
    float angularSpeed = 360/24/3600f;  // degrees per second

	void Start () {
		
	}
	
	void Update () {
        float angularIncrement = Time.deltaTime * angularSpeed * timeScale;
        gameObject.transform.Rotate(new Vector3(angularIncrement,0,0));
	}
}
