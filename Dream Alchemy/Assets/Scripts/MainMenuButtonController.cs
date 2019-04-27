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

    public GameObject MissionDisplayButton;
    public GameObject MissionUI;

    MovementController MC;

    GameObject Camera;


    private void Start()
    {
        StartButton.onClick.AddListener(StartButtonClicked);
        OptionsButton.onClick.AddListener(OptionsButtonClicked);
        QuitButton.onClick.AddListener(QuitButtonClicked);

        Camera = GameObject.Find("Main Camera");

        MC = GameObject.FindObjectOfType(typeof(MovementController)) as MovementController;
    }

    void StartButtonClicked()
    {
        Camera.GetComponent<AudioSource>().Play();
        gameObject.SetActive(false);
        MissionUI.SetActive(true);
        MissionDisplayButton.SetActive(true);
        MC.UnlockMovement();
        MC.ClosePauseMenu();
    }

    void OptionsButtonClicked()
    {
        
    }
    void QuitButtonClicked()
    {

    }
}
