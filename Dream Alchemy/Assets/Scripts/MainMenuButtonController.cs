using UnityEngine;
using UnityEngine.UI;


public class MainMenuButtonController : MonoBehaviour
{
    public Button StartButton;
    public Button OptionsButton;
    public Button QuitButton;

    public GameObject OptionsMenu;

    public GameObject MissionDisplayButton;
    public GameObject MissionUI;
    public GameObject TutorialUI;

    MovementController MC;

    GameObject Camera;

    private bool TutorialRead=false;

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
        if (TutorialRead == false) { 
            TutorialUI.SetActive(true);
            TutorialRead = true;
        }
        MC.UnlockMovement();
        MC.ClosePauseMenu();
    }

    void OptionsButtonClicked()
    {
        gameObject.SetActive(false);
        OptionsMenu.SetActive(true);
    }
    void QuitButtonClicked()
    {
        Application.Quit();
    }
}
