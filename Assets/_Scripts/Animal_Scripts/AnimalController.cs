using UnityEngine;
using System.Collections;

public class AnimalController : MonoBehaviour {
	private IAnimalAction action_;
	private IAnimalMovement movement_;
	public string animalName = "mouzou";
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
	
	}

	public void setAction(IAnimalAction action)
	{
		action_ = action;
		action_.playAction();
	}
	public void setMovement(IAnimalMovement movement)
	{
		movement_ = movement;
		movement_.move ();
	}


}
