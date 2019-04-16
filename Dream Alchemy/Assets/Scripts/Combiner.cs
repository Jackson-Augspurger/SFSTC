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
            CheckedOnce = true;
            CheckCombo(left, right);
        }

    }

    public GameObject CheckCombo(GameObject left, GameObject right)
    {
        GameObject newPot = null;

        //Make Yellow
        if (left.transform.GetChild(0).name == "Noxion" && right.transform.GetChild(0).name == "Strena")
        {
            Destroy(left.transform.GetChild(0).gameObject); Destroy(right.transform.GetChild(0).gameObject);
            newPot = Instantiate(Laught, output.transform);
            newPot.name = Laught.name;
        }
        //Make Orange
        if (left.transform.GetChild(0).name == "Laught" && right.transform.GetChild(0).name == "Strena")
        {
            Destroy(left.transform.GetChild(0).gameObject); Destroy(right.transform.GetChild(0).gameObject);
            newPot = Instantiate(Bundium, output.transform);
            newPot.name = Bundium.name;
        }
        //Make Cyan
        if (left.transform.GetChild(0).name == "Baneberry" && right.transform.GetChild(0).name == "Mandium")
        {
            Destroy(left.transform.GetChild(0).gameObject); Destroy(right.transform.GetChild(0).gameObject);
            newPot = Instantiate(Tranquesia, output.transform);
            newPot.name = Tranquesia.name;
        }
        //Make Purple
        if (left.transform.GetChild(0).name == "Strena" && right.transform.GetChild(0).name == "Serecessa")
        {
            Destroy(left.transform.GetChild(0).gameObject); Destroy(right.transform.GetChild(0).gameObject);
            newPot = Instantiate(Wiggen, output.transform);
            newPot.name = Wiggen.name;
        }
        //Make Magenta
        if (left.transform.GetChild(0).name == "Pompion" && right.transform.GetChild(0).name == "Wiggen")
        {
            Destroy(left.transform.GetChild(0).gameObject); Destroy(right.transform.GetChild(0).gameObject);
            newPot = Instantiate(Emeragon, output.transform);
            newPot.name = Emeragon.name;
        }
        //Make Red-Orange
        if (left.transform.GetChild(0).name == "Strena" && right.transform.GetChild(0).name == "Bundium")
        {
            Destroy(left.transform.GetChild(0).gameObject); Destroy(right.transform.GetChild(0).gameObject);
            newPot = Instantiate(Erumpet, output.transform);
            newPot.name = Erumpet.name;
        }
        //Make Mulberry
        if (left.transform.GetChild(0).name == "Moonseed" && right.transform.GetChild(0).name == "Strena")
        {
            Destroy(left.transform.GetChild(0).gameObject); Destroy(right.transform.GetChild(0).gameObject);
            newPot = Instantiate(Everklena, output.transform);
            newPot.name = Everklena.name;
        }
        //Make Yellow-Green
        if (left.transform.GetChild(0).name == "Laught" && right.transform.GetChild(0).name == "Noxin")
        {
            Destroy(left.transform.GetChild(0).gameObject); Destroy(right.transform.GetChild(0).gameObject);
            newPot = Instantiate(Quodot, output.transform);
            newPot.name = Quodot.name;
        }
        //Make Turquoise
        if (left.transform.GetChild(0).name == "Baneberry" && right.transform.GetChild(0).name == "Tentacula")
        {
            Destroy(left.transform.GetChild(0).gameObject); Destroy(right.transform.GetChild(0).gameObject);
            newPot = Instantiate(Redote, output.transform);
            newPot.name = Redote.name;
        }
        //Make Blue-Green
        if (left.transform.GetChild(0).name == "Serecessa" && right.transform.GetChild(0).name == "Noxion")
        {
            Destroy(left.transform.GetChild(0).gameObject); Destroy(right.transform.GetChild(0).gameObject);
            newPot = Instantiate(Mandium, output.transform);
            newPot.name = Mandium.name;
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
