using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed; //shows up in inspector as an editable property. Public allows changes in unity editor

    private Rigidbody rb; //creates a variable that holds the reference to the rigidbody we want to access

    private int count; //holds score count 

    public Text countText; //holds reference to UI text component on UI text game object. Need to set starting value 

    public Text winText;

    private void Start() //called on first frame script is active 
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        setCountText();
        winText.text = "";
    }

    private void FixedUpdate() //called before performing any physics calculation
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); //record input from horizontal and veritcal axis
        float moveVertical = Input.GetAxis("Vertical");
                                                            //grabs input from the player on the keyboard
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); 
                                                             //variable that holds the float variables that record the input from the player. 
                                                             //Used in the Addforce function
        rb.AddForce(movement * speed);
        //Vector3(x, y, z)
    }

    void OnTriggerEnter(Collider other) //called by Unity when player object first touches a trigger collider
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
                other.gameObject.SetActive(false); //deactivates pickup objects   //is this game object tagged with tag ?
                count += 1;                            //increments pick up counter
                setCountText();
        }                                        
    }

    void setCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
        {
            winText.text = "U DID IT!";
        }
    }
}
