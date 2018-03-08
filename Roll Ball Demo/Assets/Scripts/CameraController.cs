using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offset; //take current transformed pos. of camera and sub trans form pos. of the player to find difference

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position; //
	}
	
	// Garanteed to run after all items have run in "Update"
	void LateUpdate () {
        transform.position = player.transform.position + offset; //As we move player, each frame the camera is moved to a position 
                                                                 //aligned with the player object 
	}
}
