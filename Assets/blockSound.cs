using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockSound : MonoBehaviour {
    public AudioClip block;


    // Use this for initialization
    void Start () {

       
		
	}
	
	// Update is called once per frame
	void Update () {
       

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "cubeTag" || other.gameObject.tag == "groundTag") {
            AudioSource audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.clip = block;
            audioSource.Play();
        }
    }
}
