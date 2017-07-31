using UnityEngine;
using System.Collections;


//master
public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	float startTemp = 160f;
	float currentEnvelopeTemp; 
	float burnAcc = 500;
	float coolAcc = -500;
	float coolingRate =10;



	void Start()
	{
		rb = GetComponent<Rigidbody>();
		currentEnvelopeTemp = startTemp;
	}	

	void FixedUpdate ()
	{
		

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		float burn = Input.GetAxis ("Burn");
		float cool = Input.GetAxis ("TopOpen");



		//float finalAcc = (burn * burnAcc) - coolingRate;


		//Debug.Log (burn + " current burn value");
		//Debug.Log (coolingRate + " currnet cool value");
		//Debug.Log (burnAcc + " current burnACC");
		//Debug.Log (currentEnvelopeTemp + " current ETemp");
		//Debug.Log (finalAcc + " FinalAcc");
		Debug.Log (cool + " cooling");

		//this assigns a value to the xz vector
		Vector3 xzmovement = new Vector3 (moveHorizontal * 500, 0, moveVertical * 500);
		//		Debug.Log ("Current Altitude " + altitude);
		//this moves the rigid body


		rb.AddForce(xzmovement);
		if (burn == 1) 
		{
			Invoke("BurnDelay", 4.0f);
		}
		if (cool == 1) 
		{
			Invoke("TopOpenDelay", 3.0f);
		}




	}
	void BurnDelay()
	{
		
		float finalAcc = burnAcc;
		Vector3 movementy = new Vector3 (0,finalAcc,0);
		rb.AddForce(movementy);
	}

	void TopOpenDelay()
	{
		float topOpen = coolAcc;
		Vector3 coolMovement = new Vector3 (0, topOpen, 0);
		rb.AddForce (coolMovement);
	}

	void TopOpen ()
	{
		
	}




}
//