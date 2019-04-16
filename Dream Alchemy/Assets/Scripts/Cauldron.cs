﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cauldron : MonoBehaviour
{

    public GameObject MissionSlot1;
    public GameObject MissionSlot2;
    public GameObject MissionSlot3;

    GameObject left;
    GameObject center;
    GameObject right;

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

    void Start()
    {
        left = GameObject.Find("Left");
        center = GameObject.Find("Center");
        right = GameObject.Find("Right");
    }

    void Update()
    {
        if (Input.GetKeyDown("g"))
        {
            CheckMission(left,center,right);
        }
    }

    void CheckMission(GameObject left, GameObject center, GameObject right)
    {

        if (left.transform.GetChild(0).name == MissionSlot1.transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).name
        && center.transform.GetChild(0).name == MissionSlot1.transform.GetChild(0).transform.GetChild(1).transform.GetChild(0).name
        && right.transform.GetChild(0).name == MissionSlot1.transform.GetChild(0).transform.GetChild(2).transform.GetChild(0).name) {

            Destroy(left.transform.GetChild(0).gameObject);
            Destroy(right.transform.GetChild(0).gameObject);
            Destroy(center.transform.GetChild(0).gameObject);

            Destroy(MissionSlot1.transform.GetChild(0).gameObject);
        }

    }

}
