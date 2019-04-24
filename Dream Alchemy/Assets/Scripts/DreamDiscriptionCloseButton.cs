using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DreamDiscriptionCloseButton : MonoBehaviour
{
    public GameObject DreamDescriptionUI;
    public Button DreamDescriptionCloseButton;

    private void Start()
    {
        DreamDescriptionCloseButton.onClick.AddListener(onButtonClicked);
    }

    void onButtonClicked()
    {
        DreamDescriptionUI.SetActive(false);
    }
}
