using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {

    public float speed;

    private Rigidbody rb;
    private Collider col;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();

	}

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Interactable")
        {
            col = collision.collider;
            Debug.LogError("Interacting w/ " + col.name);    
        }
    }

    // Update is called once per frame
    void Update () {

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        // transform.rotation = Quaternion.LookRotation(movement);

        if (movement != Vector3.zero)
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement.normalized), 0.2f);

        if (transform.position.x > -4.45 && transform.position.x < 4.45 && transform.position.z >-4.45 && transform.position.z<4.45)
        {
            transform.Translate(movement * speed * Time.deltaTime, Space.World);
        }
    }

}
