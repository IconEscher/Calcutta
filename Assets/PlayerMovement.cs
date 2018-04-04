using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed;
	Rigidbody2D rb2D;
	[SerializeField]
	bool isMovingHorizontal;
	bool isMovingVertical;

	// Use this for initialization
	void Start () {
		rb2D = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");


		/*if (Input.GetKey (KeyCode.A)) 
		{
			//this.transform.Translate(new Vector2(-speed * Time.deltaTime, 0f));
			rb2D.velocity = new Vector2(-speed * Time.deltaTime, 0f);
		}

		if (Input.GetKey (KeyCode.D)) 
		{
			this.transform.Translate(new Vector2(speed * Time.deltaTime, 0f));
		}

		if (Input.GetKey (KeyCode.W)) 
		{
			this.transform.Translate(new Vector2(0f, speed * Time.deltaTime));
		}

		if (Input.GetKey (KeyCode.S)) 
		{
			this.transform.Translate(new Vector2(0f, -speed * Time.deltaTime));
		}*/
	}
}
