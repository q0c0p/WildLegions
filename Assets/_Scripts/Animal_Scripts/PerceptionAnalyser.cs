using UnityEngine;
using System.Collections;

public class PerceptionAnalyser : MonoBehaviour {

	private AnimalController animal_;
	private SphereCollider collider_;
	public float radiusZone = 10.0f;
	
	// Use this for initialization
	void Start () 
	{
		animal_ = GetComponentInParent<AnimalController> ();
		collider_ = GetComponent<SphereCollider> ();
		collider_.radius = radiusZone;
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			animal_.setAction(new Follow(animal_.gameObject,other.gameObject));
		}
	}
}
