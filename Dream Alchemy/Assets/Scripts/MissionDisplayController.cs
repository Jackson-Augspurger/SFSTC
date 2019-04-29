using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class MissionDisplayController : MonoBehaviour
{ 
    public GameObject MissionMenu;
    public Button button;
    bool onoff = true;

    void Start()
    {
        button.onClick.AddListener(OnClick);
    }
        public void OnClick()
    {
        if (onoff == false)
        {
            MissionMenu.SetActive(true);
            onoff = true;
            button.transform.GetChild(0).GetComponent<Text>().text = "Hide Dream Requests";

        }
        else if (onoff == true)
        {
            MissionMenu.SetActive(false);
            onoff = false;
            button.transform.GetChild(0).GetComponent<Text>().text = "Show Dream Requests";
        }
    }

}
