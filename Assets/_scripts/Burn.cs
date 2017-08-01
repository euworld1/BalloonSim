using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burn : MonoBehaviour 
{

	public Transform BurnerObject;
	public GameObject Prefab;
	// Use this for initialization
	void Start () 
	{
		//Fire.GetComponent<ParticleSystem>().enableEmission = true;
		//ps = GetComponent<ParticleSystem>();

	}
	void Update() 
	{
		//var emmision = ps.emission;
		//emmision.enabled = moduleEnabled;
	}

//	void OnGUI() 
//	{
//		moduleEnabled = GUI.Toggle (new Rect (25, 45, 100, 30), moduleEnabled, "Enabled");
//	}
	
	void OnTriggerEnter()
	{
		
		Debug.Log ("Hand is touching the burner start");
		//Fire.GetComponent<ParticleSystem> ().enableEmission = true;
		//burner.rigidbody.GetComponent<ParticleSystem> ().enableEmission;
		//ParticleSystem ps = GetComponent<ParticleSystem>();
		//Destroy (burner.gameObject);	
					
		Instantiate(Prefab, BurnerObject.position, BurnerObject.rotation);
		//AudioSource audio = GetComponent<AudioSource> ();

		//audio.Play;
			

	}




	void OnTriggerStay(Collider burner)
	{
		Debug.Log ("Hand is touching the burner");
	}

	void OnTriggerExit(Collider burner)
	{
		Debug.Log ("Hand is not touching the burner anymore");
		Destroy (BurnerObject, 1f);
	}
}
