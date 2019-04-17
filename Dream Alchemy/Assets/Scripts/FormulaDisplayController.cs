using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FormulaDisplayController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{ 

    public string Formula;
    public GameObject text;
    public GameObject POS;
    public GameObject NEG;

    // Update is called once per frame
    void Update()
    {
        if (text == null)
            text = GameObject.Find("Text");
        if (POS == null)
            POS = GameObject.Find("Pos");
        if (NEG == null)
            NEG = GameObject.Find("Neg");
    }

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        text.GetComponent<Text>().text = name;
        POS.GetComponent<Text>().text = Formula;
        NEG.GetComponent<Text>().text = "";


    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        text.GetComponent<Text>().text = "";
        POS.GetComponent<Text>().text = "";
        NEG.GetComponent<Text>().text = "";


    }

}
