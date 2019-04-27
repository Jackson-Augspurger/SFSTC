using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burner : MonoBehaviour
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
    public GameObject Noxin;
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

    GameObject BurnerSound;

    // Start is called before the first frame update
    void Start()
    {
        slot = GameObject.Find("BurnerSlot");

        FU = GameObject.FindObjectOfType(typeof(FormulaUnlock)) as FormulaUnlock;

        BurnerSound = GameObject.Find("Burner");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("g"))
        {
            CheckBurnable(slot);
        }

    }

    void CheckBurnable(GameObject slot)
    {
        GameObject newPot = null;

        //Make Brown
        if (slot.transform.GetChild(0).name == "Bundium")
        {
            Destroy(slot.transform.GetChild(0).gameObject);
            newPot = Instantiate(Tolipan, slot.transform);
            newPot.name = Tolipan.name;
            FU.Unlock(Tolipan);
            BurnerSound.GetComponent<AudioSource>().Play();

        }
        //Make Navy
        if (slot.transform.GetChild(0).name == "Serecessa")
        {
            Destroy(slot.transform.GetChild(0).gameObject);
            newPot = Instantiate(Antia, slot.transform);
            newPot.name = Antia.name;
            FU.Unlock(Antia);
            BurnerSound.GetComponent<AudioSource>().Play();

        }

    }

}

