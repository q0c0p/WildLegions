using UnityEngine;
using System.Collections;

public class AnimalController : MonoBehaviour {
	private IAgentAction action_;
	public string animalName = "mougou";
	// Use this for initialization
	void Start () {
		action_ = new WalkAround(gameObject);
	}

	// Update is called once per frame
	void FixedUpdate () {

		if (action_ != null)
			action_.playAction();

	}

	public void setAction(IAgentAction action)
	{
		/* Always delete properly the current action we need it to stop the coroutines if any  */
		if (action_ != null)
			action_.stopAction ();

		action_ = action;
	}

	public IAgentAction getAction()
	{
		return action_;
	}

}
