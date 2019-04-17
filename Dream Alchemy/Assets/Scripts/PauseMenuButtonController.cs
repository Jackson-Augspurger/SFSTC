using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenuButtonController : MonoBehaviour
{
    public Button ReturnToMainMenuButton;
    public Button OptionsButton;
    public Button QuitButton;

    public GameObject MainMenu;

    public GameObject MissionDisplayButton;
    public GameObject MissionUI;

    MovementController MC;

    private void Start()
    {
        ReturnToMainMenuButton.onClick.AddListener(MainMenuButtonClicked);
        OptionsButton.onClick.AddListener(OptionsButtonClicked);
        QuitButton.onClick.AddListener(QuitButtonClicked);

        MC = GameObject.FindObjectOfType(typeof(MovementController)) as MovementController;
    }

    void MainMenuButtonClicked()
    {
        gameObject.SetActive(false);
        MainMenu.SetActive(true);
        MissionUI.SetActive(false);
        MissionDisplayButton.SetActive(false);
        MC.LockMovement();

    }

    void OptionsButtonClicked()
    {

    }
    void QuitButtonClicked()
    {

    }
}
