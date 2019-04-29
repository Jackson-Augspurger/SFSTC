using UnityEngine;
using UnityEngine.UI;

public class OptionsMenuButtonController : MonoBehaviour
{
    public Button BackButton;

    public GameObject PauseMenu;

    private void Start()
    {
        BackButton.onClick.AddListener(BackButtonClicked);
    }

    void BackButtonClicked()
    {
        gameObject.SetActive(false);
        PauseMenu.SetActive(true);

    }
}
