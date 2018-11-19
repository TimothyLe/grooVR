using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerGrab : MonoBehaviour {
    public bool isContact = false;
    public bool isGrabbed = false;
    public bool oneShot = false;
    public AudioClip clip;
    private AudioSource source;
    float volMin = 0.5f;
    float volMax = 1.0f;

    public GameObject DrumHead;

    IEnumerator grow()
    {
        DrumHead.GetComponent<Transform>().localScale += new Vector3(0.1f, 0.1f, 0.1f);
        yield return new WaitForSeconds(.25f);
        DrumHead.GetComponent<Transform>().localScale -= new Vector3(0.1f, 0.1f, 0.1f);
    }

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }
	// Use this for initialization
	void Start () {
        Debug.Log("Starting.");
    }
	
	// Update is called once per frame
	void Update () {
        if(isContact == true)
        {
            if (oneShot == false)
            {
                source.PlayOneShot(clip, 1F);
                StartCoroutine(grow());
                oneShot = true;
            }
           
            
        }
        else
        {
            oneShot = false;
        }

        //if(GvrController.ClickButtonDown)
        //      {
        //          if(isContact == true)
        //          {

        //              //if (isGrabbed == false)
        //              //{
        //              //    Debug.Log("Grab button pressed.");
        //              //    isGrabbed = true;
        //              //    objectGrabbed.GetComponent<Transform>().parent = gameObject.transform;
        //              //    objectGrabbed.GetComponent<Rigidbody>().isKinematic = true;
        //              //    //pickupcan
        //              //}
        //              //else
        //              //{
        //              //    Debug.Log("Grab button released.");
        //              //    isGrabbed = false;
        //              //    objectGrabbed.GetComponent<Transform>().parent = null;
        //              //    objectGrabbed.GetComponent<Rigidbody>().isKinematic = false;
        //              //    //dropobject
        //              //}

        //          }
        //      }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision enter");
        isContact = true;
        DrumHead = other.gameObject;
    }

    void OnTriggerExit(Collider other)
    {
        isContact = false;
        Debug.Log("Collision Exit.");
    }
}
