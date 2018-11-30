using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerGrab : MonoBehaviour {
    public bool isContact = false;
    public bool isGrabbed = false;
    public bool oneShot = false;

    public AudioClip SnareClip;
    public AudioClip FloorTomClip;
    public AudioClip HighTomClip;
    public AudioClip RideClip;
    public AudioClip HiHatClip;
    public AudioClip CrashClip;
    public AudioClip BassClip;

    private AudioSource source;
    float volMin = 0.5f;
    float volMax = 1.0f;
    public float velToVol = .2F;
    public float hitVol = 1F;

    public GameObject DrumHead;

    IEnumerator grow()
    {
        DrumHead.GetComponent<Transform>().localScale += new Vector3(0.025f, 0.025f, 0.025f);
        yield return new WaitForSeconds(.25f);
        DrumHead.GetComponent<Transform>().localScale -= new Vector3(0.025f, 0.025f, 0.025f);
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
        if (GvrController.ClickButtonDown)
        {
            if (oneShot == false)
            {
                source.PlayOneShot(BassClip, 1F);
                oneShot = true;
            }
        }
        else if (isContact == true)
        {
            if (oneShot == false)
            {
                if(DrumHead.gameObject.CompareTag("Snare"))
                {
                    source.PlayOneShot(SnareClip, 1F);
                }
                else if(DrumHead.gameObject.CompareTag("FloorTom"))
                {
                    source.PlayOneShot(FloorTomClip, 1F);
                }
                else if (DrumHead.gameObject.CompareTag("Crash"))
                {
                    source.PlayOneShot(CrashClip, 1F);
                }
                else if (DrumHead.gameObject.CompareTag("HighTom"))
                {
                    source.PlayOneShot(HighTomClip, 1F);
                }
                else if (DrumHead.gameObject.CompareTag("Ride"))
                {
                    source.PlayOneShot(RideClip, 1F);
                }
                else if (DrumHead.gameObject.CompareTag("HiHat"))
                {
                    source.PlayOneShot(HiHatClip, 1F);
                }
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
