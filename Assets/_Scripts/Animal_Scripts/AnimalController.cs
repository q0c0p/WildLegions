using UnityEngine;
using System.Collections;

public class AnimalController : MonoBehaviour {
	private AnimalAction action;
	public string animalName = "mouzou";
	// Use this for initialization
	void Start () {
		action = new Follow();
		action.playAction(this,gameObject);
	}
	public void doSomething()
	{
		action = new Eat();
		action.playAction(this,gameObject);
	}
	// Update is called once per frame
	void Update () {
	
	}

}
