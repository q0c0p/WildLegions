using UnityEngine;
using System.Collections;

public class NearZoneTrigger : MonoBehaviour {
	private AnimalController animal_;
	private SphereCollider collider_;
	public float radiusZone = 2.0f;
	// Use this for initialization
	void Start () {
		animal_ = GetComponentInParent<AnimalController> ();
		collider_ = GetComponent<SphereCollider> ();
		collider_.radius = radiusZone;
	}
	void onTriggerEnter(Collider other)
	{
		print ("something is there");
		if (other.tag == "Player") {
			print ("I go away from the player");
			animal_.setAction(new GoAwayFrom(other.gameObject));
		}
	}
}
