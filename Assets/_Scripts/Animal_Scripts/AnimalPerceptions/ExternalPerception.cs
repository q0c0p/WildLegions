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
			animal_.getAffectiveState();
			animal_.chooseAction(other.gameObject);
		}


		/*if we find the content interest*/

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
				/*
				 *  If we trigger a new action
				 */
				if(!animal_.getMemory ().isInMemory(action))
				{
					animal_.getMemory ().updateAction(action);
					if(action.isPerceived() != null)
					{
						animal_.getAffectiveState().update(action.isPerceived());
						animal_.getMemory ().updateAffectiveState(animal_.getAffectiveState());
					}
					animal_.chooseAction(other.gameObject);
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
