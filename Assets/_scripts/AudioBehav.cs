using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBehav : MonoBehaviour {

	private AudioSource audio;
	public GameObject BurnerSound;

	// Use this for initialization
	void Start () {
		AudioSource audio = GetComponent<AudioSource> ();
		//audio.Play ();

	}

	
	// Update is called once per frame
	void Update () {
		

		
	}

	void onTriggerEnter()
	{
		audio.Play();
		Debug.Log("audio.Play()");


	}
	void onTriggerExit() 
	{
		
	}

}
