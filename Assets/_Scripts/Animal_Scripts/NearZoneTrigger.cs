using UnityEngine;
using System.Collections;

public class NearZoneTrigger : MonoBehaviour {
	AnimalController animal;
	// Use this for initialization
	void Start () {
		animal = GetComponentsInParent<AnimalController> ()[0];
		animal.doSomething ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
