using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collision : MonoBehaviour {

    public Text score;
    private float points;

    // Use this for initialization
    void Start () {

        score.text = 0.ToString();

	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.tag == "GoodBubble")
        {
            points++;
            score.text = (points).ToString();

        }

       if(collision.gameObject.tag=="BadBubble")
        {
            points--;
            score.text = (points).ToString();
        }

        Destroy(collision.gameObject);

    }

}
