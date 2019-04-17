using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diluter : MonoBehaviour
{

    GameObject slot;

    #region Potion GameObjects

    public GameObject Antia;
    public GameObject Baneberry;
    public GameObject Bundium;
    public GameObject Emeragon;
    public GameObject Erumpet;
    public GameObject Everklena;
    public GameObject Laught;
    public GameObject Mandium;
    public GameObject Moonseed;
    public GameObject Noxion;
    public GameObject Ponpion;
    public GameObject Quodot;
    public GameObject Redote;
    public GameObject Serecessa;
    public GameObject Strena;
    public GameObject Tentacula;
    public GameObject Tolipan;
    public GameObject Tranquesia;
    public GameObject Wiggen;

    #endregion

    FormulaUnlock FU;


    // Start is called before the first frame update
    void Start()
    {
        slot = GameObject.Find("DiluterSlot");

        FU = GameObject.FindObjectOfType(typeof(FormulaUnlock)) as FormulaUnlock;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("g"))
        {
            CheckDilutable(slot);
        }


    }

    void CheckDilutable(GameObject slot)
    {
        GameObject newPot = null;

        //Make Pink
        if (slot.transform.GetChild(0).name == "Strena")
        {
            Destroy(slot.transform.GetChild(0).gameObject);
            newPot = Instantiate(Ponpion, slot.transform);
            newPot.name = Ponpion.name;
            FU.Unlock(Ponpion);

        }
        //Make Light Blue
        if (slot.transform.GetChild(0).name == "Serecessa")
        {
            Destroy(slot.transform.GetChild(0).gameObject);
            newPot = Instantiate(Baneberry, slot.transform);
            newPot.name = Baneberry.name;
            FU.Unlock(Baneberry);

        }
        //Make Light Purple
        if (slot.transform.GetChild(0).name == "Wiggen")
        {
            Destroy(slot.transform.GetChild(0).gameObject);
            newPot = Instantiate(Moonseed, slot.transform);
            newPot.name = Moonseed.name;
            FU.Unlock(Moonseed);

        }
        //Make Light Green
        if (slot.transform.GetChild(0).name == "Noxion")
        {
            Destroy(slot.transform.GetChild(0).gameObject);
            newPot = Instantiate(Tentacula, slot.transform);
            newPot.name = Tentacula.name;
            FU.Unlock(Tentacula);

        }

    }

}

