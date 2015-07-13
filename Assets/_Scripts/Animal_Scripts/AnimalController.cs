using UnityEngine;
using System.Collections;

public class AnimalController : MonoBehaviour {
	private IAgentAction action_;
	public string animalName_ = "mougou";
	public AffectiveState affectiveState_;
	public Memory memory_;



	// Use this for initialization
	void Start () {
		action_ = new WalkAround(gameObject);
		affectiveState_ = new AffectiveState(0,0,0);
		memory_ = new Memory ();
	
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

	public AffectiveState getAffectiveState()
	{
		return affectiveState_;
	}
	public Memory getMemory()
	{
		return memory_;
	}
	public void chooseAction(GameObject other)
	{
		/*first of all what is the over represent emotion */
		float fear = affectiveState_.getFear ();
		float love = affectiveState_.getLove ();
		float anger = affectiveState_.getAnger ();
		if (fear > love && fear > anger && fear > 3) {
			action_ = new GoAwayFrom(gameObject,other);
		}
		if (anger > love && fear < anger && anger > 5) {
			action_ = new Attack(gameObject,other);
		}
		if (anger < love && fear < love && love > 5) {
			action_ = new Follow(gameObject,other);
		}


	}

	void OnClick(){

	}
	/*void OnTriggerStay(GameObject other){
		if (other.tag == "Player") {
			canvasDisplay_.setState(true);
		}
	}
*/
}
