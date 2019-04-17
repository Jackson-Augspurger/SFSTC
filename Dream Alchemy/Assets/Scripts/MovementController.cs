using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MovementController : MonoBehaviour {

    public float speed;
    public GameObject RecipesBook;
    public GameObject ClosetUI;
    public GameObject CauldronUI;
    public GameObject BurnerUI;
    public GameObject CombinerUI;
    public GameObject DiluterUI;

    public GameObject PauseMenu;

    public GameObject InventoryPanel;
    public GameObject ClosetPanel;
    public GameObject CauldronPanel;
    public GameObject CombinerPanel;
    public GameObject BurnerPanel;
    public GameObject DiluterPanel;
    public GameObject FormulaBookPanel;

    private Boolean Movlock = true;

    private Rigidbody rb;
    private Collider col;
    private Boolean RecipeBookUI = false;
    private Boolean InMenu = false;
    private Boolean InPauseMenu = false;

    public static MovementController instance;

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
        

        if (movement != Vector3.zero && Movlock!=true)
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
                    ClosetPanel.SetActive(true);
                    InventoryPanel.SetActive(true);
                }
                else if (col.name == "Cauldron")
                {
                    CauldronUI.SetActive(true);
                    CauldronPanel.SetActive(true);
                    InventoryPanel.SetActive(true);
                }
                else if (col.name == "Burner")
                {
                    BurnerUI.SetActive(true);
                    BurnerPanel.SetActive(true);
                    InventoryPanel.SetActive(true);
                }
                else if (col.name == "Combiner")
                {
                    CombinerUI.SetActive(true);
                    CombinerPanel.SetActive(true);
                    InventoryPanel.SetActive(true);
                }
                else if (col.name == "Diluter")
                {
                    DiluterUI.SetActive(true);
                    DiluterPanel.SetActive(true);
                    InventoryPanel.SetActive(true);
                }

                InMenu = true;
            }

            else if (InMenu == true)
            {

                if (col.name == "Closet")
                {
                    ClosetUI.SetActive(false);
                    ClosetPanel.SetActive(false);
                    InventoryPanel.SetActive(false);
                }
                else if (col.name == "Cauldron")
                {
                    CauldronUI.SetActive(false);
                    CauldronPanel.SetActive(false);
                    InventoryPanel.SetActive(false);
                }
                else if (col.name == "Burner")
                {
                    BurnerUI.SetActive(false);
                    BurnerPanel.SetActive(false);
                    InventoryPanel.SetActive(false);
                }
                else if (col.name == "Combiner")
                {
                    CombinerUI.SetActive(false);
                    CombinerPanel.SetActive(false);
                    InventoryPanel.SetActive(false);
                }
                else if (col.name == "Diluter")
                {
                    DiluterUI.SetActive(false);
                    DiluterPanel.SetActive(false);
                    InventoryPanel.SetActive(false);
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
            if (InMenu == false)
            {
                if (RecipeBookUI == false)
                {
                    RecipesBook.SetActive(true);
                    RecipeBookUI = true;
                    Movlock = true;
                    FormulaBookPanel.SetActive(true);
                    InventoryPanel.SetActive(true);
                }
                else if (RecipeBookUI == true)
                {
                    RecipesBook.SetActive(false);
                    RecipeBookUI = false;
                    Movlock = false;
                    FormulaBookPanel.SetActive(false);
                    InventoryPanel.SetActive(false);
                }

            }
        }

        if (Input.GetKeyDown("escape"))
        {

            if (InPauseMenu == false)
            {
                PauseMenu.SetActive(true);
                InMenu = true;
                InPauseMenu = true;
            }
            else if (InPauseMenu == true)
            {
                PauseMenu.SetActive(false);
                InMenu = false;
                InPauseMenu = false;
            }

        }


    }

    public void ClosePauseMenu()
    {
        InPauseMenu = false;
    }

    public void LockMovement()
    {
        Movlock = true;
    }

    public void UnlockMovement()
    {
        Movlock = false; 
    }


}
