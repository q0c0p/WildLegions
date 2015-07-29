using UnityEngine;
using System.Collections;

public class NearZoneTrigger : MonoBehaviour {

	private AnimalController animal_;
	private SphereCollider collider_;
	public float radiusZone = 1.0f;

	// Use this for initialization
	void Start () {

		animal_ = GetComponentInParent<AnimalController> ();
		collider_ = GetComponent<SphereCollider> ();
		collider_.radius = radiusZone;

	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			MonoBehaviour.print("near zone trigger");
			animal_.getArtificialIntelligence().sendEvent(new ThreatEvent(other.gameObject));
		}
		if (other.tag == "Food") {
			animal_.getArtificialIntelligence().sendEvent(new GetFoodEvent(other.gameObject));
		}
	}

}
