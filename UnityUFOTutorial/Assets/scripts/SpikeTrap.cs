using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeTrap : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    //OnTriggerEnter2D is called whenever this object overlaps with a trigger collider.
    void OnTriggerEnter2D(Collider2D other)
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("Spikes"))

            //... then set the other object we just collided with to inactive.
                 SceneManager.LoadScene("Main");
    }


    // Update is called once per frame
    void Update () {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...



    }
}
