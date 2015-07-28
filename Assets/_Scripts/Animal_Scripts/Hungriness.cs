using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Hungriness : MonoBehaviour {

	public float globalHunger_ = 100f;		//values to rendomize eventually
	float hungryTrigger_ = 60;
	float starveTrigger_ = 30;
	float hungrinessProgressRate_;
	public Slider slider_;

	void Start () {
		hungrinessProgressRate_ = 5f;
		StartCoroutine(HungerCoroutine());
	}

	void Update() {

		slider_.value = globalHunger_;
		//slider_.value = Mathf.MoveTowards (slider_.value, 100.0f, 0.15f);

	}



	IEnumerator HungerCoroutine () {

		while (true) {
			DecreaseHungerState (hungrinessProgressRate_);
			yield return new WaitForSeconds (2f);
		}


	}
	
	void DecreaseHungerState(float rate){
		globalHunger_ -= rate;
		if (globalHunger_ < hungryTrigger_  && globalHunger_ > starveTrigger_) {
			GetComponent<AnimalController> ().getArtificialIntelligence ().sendEvent (new HungerEvent());
		} 
		if (globalHunger_ < starveTrigger_ ) {
			GetComponent<AnimalController> ().getArtificialIntelligence ().sendEvent (new HungerEvent());
		} 
	}

	void StopLookingForFood() {
		//GetComponent<AnimalController>().setAction(new WalkAround(gameObject));
	}
}
