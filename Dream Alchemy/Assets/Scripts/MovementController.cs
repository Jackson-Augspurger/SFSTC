using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MovementController : MonoBehaviour {

    public float speed;
    public GameObject RecipesBook;
    public GameObject ClosetUI;
    public GameObject CauldronUI;
    public GameObject PrepTableUI;


    private Rigidbody rb;
    private Collider col;
    private Boolean RecipeBookUI = false;
    private Boolean InMenu = false;


	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();

	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Interactable")
        {
            col = other;
            //Debug.LogError("Interacting w/ " + col.name);    
        }
    }

    private void OnTriggerExit(Collider other)
    {
        col = null;

    }

    // Update is called once per frame
    void Update () {

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if (InMenu == true)
            movement = Vector3.zero;
        

        if (movement != Vector3.zero)
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement.normalized), 0.2f);



        if (transform.position.x > -4.45 && transform.position.x < 4.45 && transform.position.z >-4.45 && transform.position.z<4.45)
        {
            transform.Translate(movement * speed * Time.deltaTime, Space.World);
        }

        if (Input.GetKeyDown("e"))
        {
            if (col != null && InMenu == false)
            {

                if (col.name == "Closet")
                {
                    ClosetUI.SetActive(true);
                }
                if (col.name == "Cauldron")
                {
                    CauldronUI.SetActive(true);
                }
                if (col.name == "PrepTable")
                {
                    PrepTableUI.SetActive(true);
                }

                InMenu = true;
            }

            else if (col != null && InMenu == true)
            {

                if (col.name == "Closet")
                {
                    ClosetUI.SetActive(false);

                }
                if (col.name == "Cauldron")
                {
                    CauldronUI.SetActive(false);
                }
                if (col.name == "PrepTable")
                {
                    PrepTableUI.SetActive(false);
                }

                InMenu = false;
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
