using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerController : MonoBehaviour {

	public float movementSpeed;
	public Text scoreText;
	public Text winText;

	private Rigidbody rb;
	private int gameScore;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		gameScore = 0;
		setGameScore ();
		winText.text = "";
	}


	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * movementSpeed);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("pickup")) {
			other.gameObject.SetActive (false);
			gameScore = gameScore + 1;
			setGameScore ();
		}
		//Destroy (other.gameObject);
	}

	void setGameScore()
	{
		scoreText.text = "Game Score: " + gameScore.ToString ();
		if(gameScore >= 12){
			winText.text = "You Win!";
			scoreText.text = "";
		}
	}
}
