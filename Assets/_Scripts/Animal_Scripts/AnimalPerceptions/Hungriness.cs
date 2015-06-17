using UnityEngine;
using System.Collections;

public class Hungriness : MonoBehaviour, IPerception {

	public float globalHunger_;		//values to rendomize eventually
	float hungryTrigger_;
	float fulfillment_;
	float behaviourPersistence_;
	float hungrinessProgressRate_;

	void Start () {
		globalHunger_ = 100f; 
		hungryTrigger_ = 30f;
		fulfillment_ = 70f;
		hungrinessProgressRate_ = 5f;
		behaviourPersistence_ = 60f; //to multiply with deltaTime to get a minute, 
		//also, this should be a dynamic value to adapt the amout of food available etc... to think
		StartCoroutine(HungerCoroutine());
	}

	void Update() {
		if (globalHunger_ < hungryTrigger_) {
			StartCoroutine (StartLookingForFood(behaviourPersistence_));
		}
	}

	IEnumerator HungerCoroutine () {
		while (true) {
			DecreaseHungerState (hungrinessProgressRate_);
			yield return new WaitForSeconds (300f);
		}

	}
	
	void DecreaseHungerState(float rate){
		globalHunger_ -= rate;
	}
	IEnumerator StartLookingForFood (float persistence) {
		int timer =0;
		GetComponent<AnimalController>().setAction(new LookFor(gameObject,"Food"));
		while ((timer * Time.deltaTime) < (persistence * Time.deltaTime) || globalHunger_>fulfillment_) {
			// action lookfor (food)
			timer +=1;
		}
		GetComponent<AnimalController>().setAction(new WalkAround(gameObject));
		yield return null;
	}

	void StopLookingForFood() {
		;
	}
}
