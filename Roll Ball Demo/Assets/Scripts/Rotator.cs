using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    private void Update()
    {
        //We want to change the values of the transform change every frame
        //actively rotate the transform
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime); //delta time makes it smooth and frame rate independent
    }

}
