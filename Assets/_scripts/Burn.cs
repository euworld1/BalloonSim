using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burn : MonoBehaviour 
{
	//private AudioSource burnersound;
	private Rigidbody rb;
	float startTemp = 160f;
	float currentEnvelopeTemp; 
	float burnAcc = 500;
	float coolAcc = -500;
	float coolingRate =10;


	public Transform BurnerObject;
	public GameObject Prefab;
	// Use this for initialization
	void Start () 
	{
		//burnersound = GetComponent<AudioSource> ();
		rb = GetComponent<Rigidbody>();
		currentEnvelopeTemp = startTemp;

		//burnsound = GetComponent<AudioSource> ();
		//Fire.GetComponent<ParticleSystem>().enableEmission = true;
		//ps = GetComponent<ParticleSystem>();

	}
	void Update() 
	{
		//var emmision = ps.emission;
		//emmision.enabled = moduleEnabled;
	}

	void BurnDelay()
	{

		float finalAcc = burnAcc;
		Vector3 movementy = new Vector3 (0,finalAcc,0);
		rb.AddForce(movementy);
	}

//	void OnGUI() 
//	{
//		moduleEnabled = GUI.Toggle (new Rect (25, 45, 100, 30), moduleEnabled, "Enabled");
//	}
	
	void OnTriggerEnter()
	{
		//burnersound.Play();

		//Debug.Log ("Hand is touching the burner start");
		//Fire.GetComponent<ParticleSystem> ().enableEmission = true;
		//burner.rigidbody.GetComponent<ParticleSystem> ().enableEmission;
		//ParticleSystem ps = GetComponent<ParticleSystem>();
		//Destroy (burner.gameObject);	



				
		Instantiate(Prefab, BurnerObject.position, BurnerObject.rotation);



		Invoke ("BurnDelay", 4.0f); 
		Destroy (Prefab.gameObject, 3.0f);
		//burnsound.Stop ();


		//audio.Play;
			

	}





	void OnTriggerStay(Collider burner)
	{
		Debug.Log ("Hand is touching the burner");
	}

	void OnTriggerExit(Collider burner)
	{
		Debug.Log ("Hand is not touching the burner anymore");
		//Destroy (pointlight);
		//burnersound.Stop();

	}
}
