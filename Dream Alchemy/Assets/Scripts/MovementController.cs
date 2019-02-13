using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MovementController : MonoBehaviour {

    public float speed;
    public GameObject RecipesBook;

    private Rigidbody rb;
    private Collider col;
    private Boolean RecipeBookUI = false;


	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();

	}

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Interactable")
        {
            col = collision.collider;
            //Debug.LogError("Interacting w/ " + col.name);    
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        col = null;
    }

    // Update is called once per frame
    void Update () {

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        // transform.rotation = Quaternion.LookRotation(movement);

        if (movement != Vector3.zero)
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement.normalized), 0.2f);

        if (transform.position.x > -4.45 && transform.position.x < 4.45 && transform.position.z >-4.45 && transform.position.z<4.45)
        {
            transform.Translate(movement * speed * Time.deltaTime, Space.World);
        }

        if (Input.GetKeyDown("e"))
        {
            if (col != null)
            {
                Debug.LogError("Interacting w/ " + col.name); 
            }
            else
            {
                Debug.LogError("Nope");
            }
        }

        if (Input.GetKeyDown("r"))
        {
            if (RecipeBookUI == false)
            {
                RecipesBook.SetActive(true);
                RecipeBookUI = true;
            }
            else if (RecipeBookUI == true)
            {
                RecipesBook.SetActive(false);
                RecipeBookUI = false;
            }
        }

    }


}
