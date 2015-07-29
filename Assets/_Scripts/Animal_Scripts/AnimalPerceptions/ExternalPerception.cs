using UnityEngine;
using System.Collections;

public class ExternalPerception : MonoBehaviour {
	
	public float radiusZone = 10.0f;
	private AnimalController animal_;
	private SphereCollider collider_;
	private GameObject interestGO_;
	private string interestTag_;
	
	// Use this for initialization
	void Start () 
	{
		animal_ = GetComponentInParent<AnimalController> ();
		collider_ = GetComponent<SphereCollider> ();
		collider_.radius = radiusZone;
		interestGO_ = null;
		interestTag_ = null;
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			MonoBehaviour.print("The player is there");
			other.gameObject.GetComponent<PlayerController>().addAnimalObserver(animal_);
		}


		/*if we find the content interest*/

		if (interestTag_ != null) {
			if (other.tag == interestTag_)
			{
				animal_.getArtificialIntelligence().sendEvent(new FindSmthEvent(other.gameObject));
			}
		}
		if (interestGO_ != null) {
			if (other.gameObject == interestGO_)
			{
				animal_.getArtificialIntelligence().sendEvent(new FindSmthEvent(other.gameObject));
			}
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player") {
			MonoBehaviour.print("The player is outside");
			other.gameObject.GetComponent<PlayerController>().removeAnimalObserver(animal_);
		}
	}




	public void setInterestTag(string interest)
	{
		interestGO_ = null;
		interestTag_ = interest;
	}
	public void setInterestGO(GameObject interest)
	{
		interestTag_ = null;
		interestGO_ = interest;
	}
}
