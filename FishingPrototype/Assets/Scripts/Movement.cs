using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float sinkSpeed = 0f;
    public float MovSpeed = 0f;
    public float returnSpeed = 0f;

    private bool goingDown = true;

	void Start () {
		
	}
	
	void Update () {

        //Sink Script
        if (goingDown == true && transform.position.y<0)
        {
            transform.Translate(Vector2.down * Time.deltaTime * sinkSpeed);
        }

        //Return to surface script
        if (goingDown == false && transform.position.y<0)
        {
            transform.Translate(Vector2.up * Time.deltaTime * returnSpeed);
        }

        //Move Left
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector2.left * Time.deltaTime * MovSpeed);
        }

        //Move Right
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector2.right * Time.deltaTime * MovSpeed);
        }

        //Start Return
        if (Input.GetKeyDown("r"))
        {
            goingDown = false;
        }

    }
}
