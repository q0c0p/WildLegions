using UnityEngine;
using System.Collections;

public class ExternalPerception : MonoBehaviour {
	
	public float radiusZone = 10.0f;
	private AnimalController animal_;
	private SphereCollider collider_;
	private GameObject interestGO_;
	private string interestTag_;
	private AffectiveState affectiveState_;
	
	// Use this for initialization
	void Start () 
	{
		animal_ = GetComponentInParent<AnimalController> ();
		affectiveState_ = GetComponentInParent<AffectiveState> ();
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
				
				if(GetComponentInParent<Memory>().isInMemory(action))
				{

				}
				else
				{
					GetComponentInParent<Memory>().updateMemory(action);
					if(action.isPerceived() != null)
					{
						affectiveState_.update(action);
					}
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
