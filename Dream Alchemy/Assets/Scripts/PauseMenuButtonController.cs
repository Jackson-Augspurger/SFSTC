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

    private void Start()
    {
        ReturnToMainMenuButton.onClick.AddListener(MainMenuButtonClicked);
        OptionsButton.onClick.AddListener(OptionsButtonClicked);
        QuitButton.onClick.AddListener(QuitButtonClicked);

    }

    void MainMenuButtonClicked()
    {

        
    }

    void OptionsButtonClicked()
    {

    }
    void QuitButtonClicked()
    {

    }
}
