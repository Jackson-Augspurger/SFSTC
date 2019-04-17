using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormulaUnlock : MonoBehaviour
{

    #region Potion Formula Slots

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

    public static FormulaUnlock instance;

    public void Unlock(GameObject Potion)
    {
        if (Potion.name == "Laught")
            Laught.SetActive(true);
        else if (Potion.name == "Bundium")
            Bundium.SetActive(true);
        else if (Potion.name == "Tranquesia")
            Tranquesia.SetActive(true);
        else if (Potion.name == "Wiggen")
            Wiggen.SetActive(true);
        else if (Potion.name == "Emeragon")
            Emeragon.SetActive(true);
        else if (Potion.name == "Erumpet")
            Erumpet.SetActive(true);
        else if (Potion.name == "Everklena")
            Everklena.SetActive(true);
        else if (Potion.name == "Quodot")
            Quodot.SetActive(true);
        else if (Potion.name == "Redote")
            Redote.SetActive(true);
        else if (Potion.name == "Mandium")
            Mandium.SetActive(true);

        else if (Potion.name == "Ponpion")
            Ponpion.SetActive(true);
        else if (Potion.name == "Baneberry")
            Baneberry.SetActive(true);
        else if (Potion.name == "Moonseed")
            Moonseed.SetActive(true);
        else if (Potion.name == "Tentacula")
            Tentacula.SetActive(true);

        else if (Potion.name == "Tolipan")
            Tolipan.SetActive(true);
        else if (Potion.name == "Antia")
            Antia.SetActive(true);

        else
            Debug.Log("Fuck");

    }

}
