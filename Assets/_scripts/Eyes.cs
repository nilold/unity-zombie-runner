using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour {

    private Camera eyes;
    private float defaultFOV;
    private bool isZoomed;
    [SerializeField] float zoomLevel = 1.5f;


	void Start () {
        eyes = GetComponent<Camera>();
        defaultFOV = eyes.fieldOfView;
    }
	
	// Update is called once per frame
	void Update ()
    {
        CheckZoom();
    }

    private void CheckZoom()
    {
        if (Input.GetButton("Zoom"))
        {
            ZoomIn();
        }
        else
        {
            ZoomOut();
        }
    }

    private void ZoomIn(){
        if(!isZoomed){
            eyes.fieldOfView = defaultFOV / zoomLevel;
            isZoomed = true;
        }

    }

    private void ZoomOut(){
        if(isZoomed){
            eyes.fieldOfView = defaultFOV;
            isZoomed = false;
        }
            
    }

}
