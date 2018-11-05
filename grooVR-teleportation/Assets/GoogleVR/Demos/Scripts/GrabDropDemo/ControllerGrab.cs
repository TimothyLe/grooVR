using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerGrab : MonoBehaviour {
    public bool isContact = false;
    public bool isGrabbed = false;

    public GameObject objectGrabbed;
	// Use this for initialization
	void Start () {
        Debug.Log("Starting.");
	}
	
	// Update is called once per frame
	void Update () {
		if(GvrController.ClickButtonDown)
        {
            if(isContact == true)
            {
                if (isGrabbed == false)
                {
                    Debug.Log("Grab button pressed.");
                    isGrabbed = true;
                    objectGrabbed.GetComponent<Transform>().parent = gameObject.transform;
                    objectGrabbed.GetComponent<Rigidbody>().isKinematic = true;
                    //pickupcan
                }
                else
                {
                    Debug.Log("Grab button released.");
                    isGrabbed = false;
                    objectGrabbed.GetComponent<Transform>().parent = null;
                    objectGrabbed.GetComponent<Rigidbody>().isKinematic = false;
                    //dropobject
                }
            }
        }
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision enter");
        isContact = true;
        objectGrabbed = other.gameObject;
    }

    void OnTriggerExit(Collider other)
    {
        isContact = false;
        Debug.Log("Collision Exit.");
    }
}
