using UnityEngine;
using UnityEngine.UI;



public class PauseMenuButtonController : MonoBehaviour
{
    public Button ReturnToMainMenuButton;
    public Button OptionsButton;
    public Button QuitButton;

    public GameObject MainMenu;
    public GameObject OptionsMenu;

    public GameObject MissionDisplayButton;
    public GameObject MissionUI;

    MovementController MC;

    GameObject Camera;
    GameObject Jukebox;

    private void Start()
    {
        ReturnToMainMenuButton.onClick.AddListener(MainMenuButtonClicked);
        OptionsButton.onClick.AddListener(OptionsButtonClicked);
        QuitButton.onClick.AddListener(QuitButtonClicked);

        Camera = GameObject.Find("Main Camera");
        Jukebox = GameObject.Find("Jukebox");

        MC = GameObject.FindObjectOfType(typeof(MovementController)) as MovementController;
    }

    void MainMenuButtonClicked()
    {
        Camera.GetComponent<AudioSource>().Stop();
        Jukebox.GetComponent<AudioSource>().Stop();
        gameObject.SetActive(false);
        MainMenu.SetActive(true);
        MissionUI.SetActive(false);
        MissionDisplayButton.SetActive(false);
        MC.LockMovement();

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
