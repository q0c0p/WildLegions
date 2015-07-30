using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {

	GameObject player_;
	Vector3 movement_;  
	public float speed_ = 6f;
	public float rotateSpeed_ = 50f ;
	private Action action_;
	public List<AnimalController> animalsSeePlayer_ = new List<AnimalController>();

	
	public float smooth = 2.0F;
	// Use this for initialization
	void Start () {
		player_ = GetComponent <GameObject> ();
	}

	public Action getAction()
	{
		return action_;
	}

	void FixedUpdate ()
	{
		Rotation ();
		Move ();
		GetKeyboardInput ();
	}

	void GetKeyboardInput()
	{
		if (Input.GetButtonDown ("Fire1")) {
			MonoBehaviour.print("The player attack!");
			action_ = new PlayerAttack(gameObject);
			foreach(AnimalController animal in animalsSeePlayer_)
				animal.getArtificialIntelligence().sendEvent(action_.getEvent());
		}
		if (Input.GetButtonDown ("Fire2")) {
			MonoBehaviour.print("The player feed the animals!");
			action_ = new PlayerFeed(gameObject);
			foreach(AnimalController animal in animalsSeePlayer_)
				animal.getArtificialIntelligence().sendEvent(action_.getEvent());
		}
	}

	void Rotation ()
	{
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate(Vector3.up, rotateSpeed_ * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate(Vector3.up, -rotateSpeed_ * Time.deltaTime);
		}
	}
	
	void Move ()
	{
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate(Vector3.forward* speed_ * Time.deltaTime);
		}
		
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate(Vector3.forward* -speed_ * Time.deltaTime);
		}
	}

	public void addAnimalObserver(AnimalController animal)
	{
		animalsSeePlayer_.Add (animal);
	}
	public void removeAnimalObserver(AnimalController animal)
	{
		animalsSeePlayer_.Remove (animal);
	}




}