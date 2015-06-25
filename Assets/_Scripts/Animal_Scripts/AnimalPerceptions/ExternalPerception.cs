using UnityEngine;
using System.Collections;

public class ExternalPerception : MonoBehaviour {

	private AnimalController animal_;
	private SphereCollider collider_;
	public float radiusZone = 10.0f;
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
			animal_.setAction(new Follow(animal_.gameObject,other.gameObject));
		}
		if (interestTag_ != null) {
			if (other.tag == interestTag_)
			{
				animal_.setAction(new GoToSmth(animal_.gameObject,other.gameObject));
			}
		}
		if (interestGO_ != null) {
			if (other.gameObject == interestGO_)
			{
				animal_.setAction(new GoToSmth(animal_.gameObject,other.gameObject));
			}
		}
	}
	void OnTriggerStay(Collider other)
	{
		if (other.tag == "Player") {
			IAgentAction action = other.gameObject.GetComponent<PlayerController>().getAction();
			if(action != null)
			{
				if(action is PlayerAttack)
				{
					GetComponentInParent<Memory>().updateMemory(action);
				}
				if(action is PlayerFeed)
				{
					GetComponentInParent<Memory>().updateMemory(action);
				}
			}
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
