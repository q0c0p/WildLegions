using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Hungriness : MonoBehaviour {

	public float globalHunger_ = 100f;		//values to rendomize eventually
	float hungryTrigger_;
	float fulfillment_;
	float behaviourPersistence_;
	float hungrinessProgressRate_;
	bool isLookingForFood;
	public Slider slider_;

	void Start () {
		isLookingForFood = false;
		hungryTrigger_ = 30f;
		fulfillment_ = 70f;
		hungrinessProgressRate_ = 5f;
		behaviourPersistence_ = 60f;
		StartCoroutine(HungerCoroutine());
	}

	void Update() {

		slider_.value = globalHunger_;
		//slider_.value = Mathf.MoveTowards (slider_.value, 100.0f, 0.15f);

	}

	IEnumerator HungerCoroutine () {

		while (true && globalHunger_ >0) {
			DecreaseHungerState (hungrinessProgressRate_);
			yield return new WaitForSeconds (2f);
		}


	}
	
	void DecreaseHungerState(float rate){
		globalHunger_ -= rate;
		GetComponent<AnimalController> ().getArtificialIntelligence ().sendEvent (new HungerEvent());
		if (globalHunger_ < hungryTrigger_ && !isLookingForFood ) {
			print("I want to eat !!!");
			StartLookingForFood(behaviourPersistence_);
			isLookingForFood = true;
		} 
	}
	void StartLookingForFood (float persistence) {
		GetComponent<AnimalController>().setAction(new LookFor(gameObject,"Food"));
		print("I want to eat !!!");
	}

	void StopLookingForFood() {
		GetComponent<AnimalController>().setAction(new WalkAround(gameObject));
	}
}
