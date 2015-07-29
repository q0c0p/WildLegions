using UnityEngine;
using System.Collections;

public class AnimalController : MonoBehaviour {
	protected Action action_;
	protected Fatima.FatimaCore artificialIntelligence_;
	public string animalName_ = "mougou";
	public NpcAnimationAdapter anim_;



	// Use this for initialization
	protected void initialisation () {
		StartCoroutine (UpdateAICoroutine());
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
	IEnumerator UpdateAICoroutine () {
		
		while (true) {
			artificialIntelligence_.update();
			yield return new WaitForSeconds (2f);
		}
		
		
	}

}
