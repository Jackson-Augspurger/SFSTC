using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionController : MonoBehaviour
{

    /* Road map
     * ---Tutorial:
     * Sandman
     * 
     * ---Level 1:
     * Podrick
     * Marianne
     * Cedric
     * 
     * ---Level 2:
     * Junior
     * Wendy
     * Nigel
     * */

    #region Characters

    public GameObject Sandman;
    public GameObject Podrick;
    public GameObject Marianne;
    public GameObject Cedric;
    public GameObject Junior;
    public GameObject Wendy;
    public GameObject Nigel;

    #endregion

    public GameObject MissionSlot1;
    public GameObject MissionSlot2;
    public GameObject MissionSlot3;

    public static GameObject instance;

    private void Start()
    {
        PlayTutorial();
    }

    public void PlayTutorial()
    {
        Instantiate(Sandman, MissionSlot1.transform);

    }

    public void PlayLevel1()
    {
        Instantiate(Podrick, MissionSlot1.transform);
        Instantiate(Marianne, MissionSlot2.transform);
        Instantiate(Cedric, MissionSlot3.transform);

    }

    public void PlayLevel2()
    {
        Instantiate(Junior, MissionSlot1.transform);
        Instantiate(Wendy, MissionSlot2.transform);
        Instantiate(Nigel, MissionSlot3.transform);
    }
}

