using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cauldron : MonoBehaviour
{

    public GameObject MissionSlot1;
    public GameObject MissionSlot2;
    public GameObject MissionSlot3;

    GameObject left;
    GameObject center;
    GameObject right;
    GameObject CauldronSound;


    GameObject DreamInfo;

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

    public GameObject MissionUI;

    bool TutorialDone = false;
    bool LevelOneDone = false;
    MissionController mc;

    void Start()
    {
        left = GameObject.Find("Left");
        center = GameObject.Find("Center");
        right = GameObject.Find("Right");

        mc = GameObject.FindObjectOfType(typeof(MissionController)) as MissionController;

        CauldronSound = GameObject.Find("Cauldron");

    }

    void Update()
    {
        if (Input.GetKeyDown("g"))
        {
            CheckMission(left,center,right);
        }

        CheckProgression();

    }

    void CheckMission(GameObject left, GameObject center, GameObject right)
    {
        if (MissionSlot1.transform.GetChildCount() > 0)
        {
            if (left.transform.GetChild(0).name == MissionSlot1.transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).name
            && center.transform.GetChild(0).name == MissionSlot1.transform.GetChild(0).transform.GetChild(1).transform.GetChild(0).name
            && right.transform.GetChild(0).name == MissionSlot1.transform.GetChild(0).transform.GetChild(2).transform.GetChild(0).name)
            {
                MissionUI.SetActive(true);
                UpdateDreamReport(MissionSlot1.transform.GetChild(0).gameObject);

                Destroy(left.transform.GetChild(0).gameObject);
                Destroy(right.transform.GetChild(0).gameObject);
                Destroy(center.transform.GetChild(0).gameObject);

                CauldronSound.GetComponent<AudioSource>().Play();

                Destroy(MissionSlot1.transform.GetChild(0).gameObject);
            }
        }
        if (MissionSlot2.transform.GetChildCount() > 0)
        {
            if (left.transform.GetChild(0).name == MissionSlot2.transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).name
            && center.transform.GetChild(0).name == MissionSlot2.transform.GetChild(0).transform.GetChild(1).transform.GetChild(0).name
            && right.transform.GetChild(0).name == MissionSlot2.transform.GetChild(0).transform.GetChild(2).transform.GetChild(0).name)
            {

                MissionUI.SetActive(true);
                UpdateDreamReport(MissionSlot2.transform.GetChild(0).gameObject);

                Destroy(left.transform.GetChild(0).gameObject);
                Destroy(right.transform.GetChild(0).gameObject);
                Destroy(center.transform.GetChild(0).gameObject);

                CauldronSound.GetComponent<AudioSource>().Play();

                Destroy(MissionSlot2.transform.GetChild(0).gameObject);
            }
        }
        if (MissionSlot3.transform.GetChildCount() > 0)
            if (left.transform.GetChild(0).name == MissionSlot3.transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).name
            && center.transform.GetChild(0).name == MissionSlot3.transform.GetChild(0).transform.GetChild(1).transform.GetChild(0).name
            && right.transform.GetChild(0).name == MissionSlot3.transform.GetChild(0).transform.GetChild(2).transform.GetChild(0).name)
            {
                MissionUI.SetActive(true);
                UpdateDreamReport(MissionSlot3.transform.GetChild(0).gameObject);

                Destroy(left.transform.GetChild(0).gameObject);
                Destroy(right.transform.GetChild(0).gameObject);
                Destroy(center.transform.GetChild(0).gameObject);

                CauldronSound.GetComponent<AudioSource>().Play();

                Destroy(MissionSlot3.transform.GetChild(0).gameObject);

            }

    }

    void CheckProgression()
    {
#pragma warning disable CS0618 // Type or member is obsolete

        if (MissionSlot1.transform.GetChildCount() == 0 && TutorialDone == false)
        {
            Debug.Log("Tutorial done");
            mc.PlayLevel1();
            TutorialDone = true;
        }

        else if (MissionSlot1.transform.GetChildCount() == 0 && MissionSlot2.transform.GetChildCount() == 0 && MissionSlot3.transform.GetChildCount() == 0 && TutorialDone == true && LevelOneDone == false)
        {
            Debug.Log("Level 1 Done");
            mc.PlayLevel2();
            LevelOneDone = true;

        }

        else if (MissionSlot1.transform.GetChildCount() == 0 && MissionSlot2.transform.GetChildCount() == 0 && MissionSlot3.transform.GetChildCount() == 0 && TutorialDone == true && LevelOneDone == true)
        {
            //Debug.Log("Level 2 Done");
            //Play Level 3

        }
#pragma warning restore CS0618 // Type or member is obsolete


    }

    public void UpdateDreamReport(GameObject person)
    {
        DreamInfo = GameObject.Find("DreamInfo");

        int i = Mathf.RoundToInt(Random.value*10) % 3;

        if(i==0)
            DreamInfo.GetComponent<Text>().text = person.GetComponent<DreamDiscriptionController>().Dream1;
        else if(i==1)
            DreamInfo.GetComponent<Text>().text = person.GetComponent<DreamDiscriptionController>().Dream2;
        else if(i==2)
            DreamInfo.GetComponent<Text>().text = person.GetComponent<DreamDiscriptionController>().Dream3;


    }

}
