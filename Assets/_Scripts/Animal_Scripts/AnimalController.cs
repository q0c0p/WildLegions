using UnityEngine;
using System.Collections;

public class AnimalController : MonoBehaviour {
	private Action action_;
	private Fatima.FatimaCore artificialIntelligence_;
	public string animalName_ = "mougou";





	// Use this for initialization
	void Start () {
		artificialIntelligence_ = new FatimaCoreImpl (gameObject);
		action_ = new WalkAround(gameObject);
	}

	// Update is called once per frame
	void FixedUpdate () {

		if (action_ != null)
			action_.playAction();
	}

	public void setAction(Action action)
	{
		/* Always delete properly the current action we need it to stop the coroutines if any  */
		if (action_ != null)
			action_.stopAction ();

		action_ = action;
	}

	public Action getAction()
	{
		return action_;
	}

	public Fatima.FatimaCore getArtificialIntelligence()
	{
		return artificialIntelligence_;
	}

}
