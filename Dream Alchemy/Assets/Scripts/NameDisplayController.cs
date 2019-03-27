using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class NameDisplayController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject text;
    public GameObject POS;
    public GameObject NEG;

    public string pos;
    public string neg;


    private void Update()
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
        POS.GetComponent<Text>().text = pos;
        NEG.GetComponent<Text>().text = neg;

    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        text.GetComponent<Text>().text = "";
        POS.GetComponent<Text>().text = "";
        NEG.GetComponent<Text>().text = "";
    }
}