using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuButtonController : MonoBehaviour
{
    public Button StartButton;
    public Button OptionsButton;
    public Button QuitButton;

    private void Start()
    {
        StartButton.onClick.AddListener(StartButtonClicked);
        OptionsButton.onClick.AddListener(OptionsButtonClicked);
        QuitButton.onClick.AddListener(QuitButtonClicked);

    }

    void StartButtonClicked()
    {

        gameObject.SetActive(false);


    }

    void OptionsButtonClicked()
    {
        
    }
    void QuitButtonClicked()
    {

    }
}
