using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour {
    private Vector3 startPos;
    private Quaternion startRot; //handles rotation

	// Use this for initialization
	void Start () {

        startPos = GetComponent<Transform>().position;
        startRot = GetComponent<Transform>().rotation;
	}
	
	// Update is called once per frame
	void Update () {
        if(GvrController.AppButton)
        {
            gameObject.GetComponent<Transform>().position = startPos;
            gameObject.GetComponent<Transform>().rotation = startRot;
        }
	
	}
}
