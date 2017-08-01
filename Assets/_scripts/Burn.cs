using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burn : MonoBehaviour 
{

	public Transform Fire;
	private ParticleSystem ps;
	public bool moduleEnabled;

	// Use this for initialization
	void Start () 
	{
		//Fire.GetComponent<ParticleSystem>().enableEmission = true;
		ps = GetComponent<ParticleSystem>();

	}
	void Update() 
	{
		var emmision = ps.emission;
		emmision.enabled = moduleEnabled;
	}

//	void OnGUI() 
//	{
//		moduleEnabled = GUI.Toggle (new Rect (25, 45, 100, 30), moduleEnabled, "Enabled");
//	}
	
	void OnTriggerEnter(Collider burner)
	{
		
		Debug.Log ("Hand is touching the burner start");
		//Fire.GetComponent<ParticleSystem> ().enableEmission = true;
		//burner.rigidbody.GetComponent<ParticleSystem> ().enableEmission;
		ParticleSystem ps = GetComponent<ParticleSystem>();



	}
	void OnTriggerStay(Collider burner)
	{
		Debug.Log ("Hand is touching the burner");
	}

	void OnTriggerExit(Collider burner)
	{
		Debug.Log ("Hand is not touching the burner anymore");
	}
}
