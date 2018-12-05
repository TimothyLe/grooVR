using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DaydreamElements.SwipeMenu
{
    public class ControllerGrab : MonoBehaviour
    {
        public bool isContact = false;
        public bool isGrabbed = false;
        public bool oneShot = false;
        //public bool sample = false;

        public AudioClip SnareClip;
        public AudioClip FloorTomClip;
        public AudioClip HighTomClip;
        public AudioClip RideClip;
        public AudioClip HiHatClip;
        public AudioClip CrashClip;
        public AudioClip BassClip;

        public AudioClip SnareClip2;
        public AudioClip FloorTomClip2;
        public AudioClip HighTomClip2;
        public AudioClip RideClip2;
        public AudioClip HiHatClip2;
        public AudioClip CrashClip2;
        public AudioClip BassClip2;

        public AudioClip SnareClip3;
        public AudioClip FloorTomClip3;
        public AudioClip HighTomClip3;
        public AudioClip RideClip3;
        public AudioClip HiHatClip3;
        public AudioClip CrashClip3;
        public AudioClip BassClip3;

        public AudioClip SnareClip4;
        public AudioClip FloorTomClip4;
        public AudioClip HighTomClip4;
        public AudioClip RideClip4;
        public AudioClip HiHatClip4;
        public AudioClip CrashClip4;
        public AudioClip BassClip4;


        private AudioSource source;
        private int SampleCounter = 1;
        float volMin = 0.5f;
        float volMax = 1.0f;
        public float velToVol = .2F;
        public float hitVol = 1F;

        public GameObject DrumHead;
        public GameObject Bass;
        //public GameObject swipeMenu;
            
        IEnumerator grow()
        {
            DrumHead.GetComponent<Transform>().localScale = new Vector3(1.0125f, 1.0125f, 1.0125f);
            yield return new WaitForSeconds(.25f);
            DrumHead.GetComponent<Transform>().localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }

        void Awake()
        {
            source = GetComponent<AudioSource>();
        }

        // Use this for initialization
        void Start()
        {
            Debug.Log("Starting.");
            Bass = GameObject.Find("Bass");
            //ChangeSample.AddListener(SelectSound);
            //swipeMenu.GetComponent<SwipeMenu>().OnSwipeSelect += OnSwipeSelect;

        }

        // Update is called once per frame
        void Update()
        {
            if (GvrController.AppButtonDown)
            {
                Debug.Log("Sample cycled.");
                ToggleSample();
            }

            if (GvrController.ClickButtonDown)
            {
                PlayBassDrum();
            }
            else if (isContact == true)
            {
                if (oneShot == false)
                {
                    if (SampleCounter == 1)
                    {
                        if (DrumHead.gameObject.CompareTag("Snare"))
                        {
                            source.PlayOneShot(SnareClip, 1F);
                        }
                        else if (DrumHead.gameObject.CompareTag("FloorTom"))
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
                    else if(SampleCounter == 2)
                    {
                        if (DrumHead.gameObject.CompareTag("Snare"))
                        {
                            source.PlayOneShot(SnareClip2, 1F);
                        }
                        else if (DrumHead.gameObject.CompareTag("FloorTom"))
                        {
                            source.PlayOneShot(FloorTomClip2, 1F);
                        }
                        else if (DrumHead.gameObject.CompareTag("Crash"))
                        {
                            source.PlayOneShot(CrashClip2, 1F);
                        }
                        else if (DrumHead.gameObject.CompareTag("HighTom"))
                        {
                            source.PlayOneShot(HighTomClip2, 1F);
                        }
                        else if (DrumHead.gameObject.CompareTag("Ride"))
                        {
                            source.PlayOneShot(RideClip2, 1F);
                        }
                        else if (DrumHead.gameObject.CompareTag("HiHat"))
                        {
                            source.PlayOneShot(HiHatClip2, 1F);
                        }
                        StartCoroutine(grow());
                        oneShot = true;
                    }
                    else if (SampleCounter == 3)
                    {
                        if (DrumHead.gameObject.CompareTag("Snare"))
                        {
                            source.PlayOneShot(SnareClip3, 1F);
                        }
                        else if (DrumHead.gameObject.CompareTag("FloorTom"))
                        {
                            source.PlayOneShot(FloorTomClip3, 1F);
                        }
                        else if (DrumHead.gameObject.CompareTag("Crash"))
                        {
                            source.PlayOneShot(CrashClip3, 1F);
                        }
                        else if (DrumHead.gameObject.CompareTag("HighTom"))
                        {
                            source.PlayOneShot(HighTomClip3, 1F);
                        }
                        else if (DrumHead.gameObject.CompareTag("Ride"))
                        {
                            source.PlayOneShot(RideClip3, 1F);
                        }
                        else if (DrumHead.gameObject.CompareTag("HiHat"))
                        {
                            source.PlayOneShot(HiHatClip3, 1F);
                        }
                        StartCoroutine(grow());
                        oneShot = true;
                    }
                    else if (SampleCounter == 4)
                    {
                        if (DrumHead.gameObject.CompareTag("Snare"))
                        {
                            source.PlayOneShot(SnareClip4, 1F);
                        }
                        else if (DrumHead.gameObject.CompareTag("FloorTom"))
                        {
                            source.PlayOneShot(FloorTomClip4, 1F);
                        }
                        else if (DrumHead.gameObject.CompareTag("Crash"))
                        {
                            source.PlayOneShot(CrashClip4, 1F);
                        }
                        else if (DrumHead.gameObject.CompareTag("HighTom"))
                        {
                            source.PlayOneShot(HighTomClip4, 1F);
                        }
                        else if (DrumHead.gameObject.CompareTag("Ride"))
                        {
                            source.PlayOneShot(RideClip4, 1F);
                        }
                        else if (DrumHead.gameObject.CompareTag("HiHat"))
                        {
                            source.PlayOneShot(HiHatClip4, 1F);
                        }
                        StartCoroutine(grow());
                        oneShot = true;
                    }
                }

            }
            else
            {
                oneShot = false;
            }
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

        void ToggleSample()
        {
            SampleCounter++;
            if(SampleCounter == 5)
            {
                SampleCounter = 1;
            }
        }

        void PlayBassDrum()
        {
            if (oneShot == false)
            {
                if (SampleCounter == 1)
                {
                    source.PlayOneShot(BassClip, 1F);
                    oneShot = true;
                }
                else if (SampleCounter == 2)
                {
                    source.PlayOneShot(BassClip2, 1F);
                    oneShot = true;
                }
                else if (SampleCounter == 3)
                {
                    source.PlayOneShot(BassClip3, 1F);
                    oneShot = true;
                }
                else if (SampleCounter == 4)
                {
                    source.PlayOneShot(BassClip4, 1F);
                    oneShot = true;
                }

            }
            oneShot = false;
        }

       

        //int OnSwipeSelect(int x)
        //{
        //    Debug.Log(x);
        //    return x;
        //}
        

        //void SelectSound()
        //{
        //    Debug.Log("Select Sound Success.");

     
        //}
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
