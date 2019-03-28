using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combiner : MonoBehaviour
{

    GameObject left;
    GameObject right;
    GameObject output;

    bool CheckedOnce = true;

    #region Potion GameObjects

    public GameObject Antia;
    public GameObject Baneberry;
    public GameObject Bundium;
    public GameObject Emeragon;
    public GameObject Erumpet;
    public GameObject Everklena;
    public GameObject Laught;
    public GameObject Mandum;
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


    // Start is called before the first frame update
    void Start()
    {
        output = GameObject.Find("Output");
        left = GameObject.Find("Slot1");
        right = GameObject.Find("Slot2");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("g"))
        {
            CheckCombo(left, right);
        }

    }

    public GameObject CheckCombo(GameObject left, GameObject right)
    {
        GameObject newPot = null;

        if (left.transform.GetChild(0).name == "Strena" && right.transform.GetChild(0).name == "Serecessa")
        {
            Destroy(left); Destroy(right);
            newPot = Instantiate(Wiggen, output.transform);
            newPot.name = Wiggen.name;
        }

        //Checks the Inverse
        if (CheckedOnce == true)
        {
            CheckedOnce = false;
            newPot = CheckCombo(right, left);
        }

        return newPot;
    }

}
