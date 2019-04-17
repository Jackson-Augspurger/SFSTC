using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PermanentPotions : MonoBehaviour
{
    public GameObject Strena;
    public GameObject Serecessa;
    public GameObject Noxion;

    GameObject StrPar;
    GameObject SerPar;
    GameObject NoxPar;

    // Start is called before the first frame update
    void Start()
    {
        StrPar = GameObject.Find("PermanentStrena");
        SerPar = GameObject.Find("PermanentSerecessa");
        NoxPar = GameObject.Find("PermanentNoxion");

        Restock();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
            Restock();
    }

    public void Restock()
    {
#pragma warning disable CS0618 // Type or member is obsolete
        if (StrPar.transform.GetChildCount() == 0)
            Instantiate(Strena, StrPar.transform).name = "Strena";
        if (SerPar.transform.GetChildCount() == 0)
            Instantiate(Serecessa, SerPar.transform).name = "Serecessa";
        if (NoxPar.transform.GetChildCount() == 0)
            Instantiate(Noxion, NoxPar.transform).name = "Noxion";
#pragma warning restore CS0618 // Type or member is obsolete

    }

}
