using UnityEngine;
using System.Collections;

public class Hungriness : MonoBehaviour, IPerception {

	public float globalHunger_ = 100f;		//values to rendomize eventually
	float hungryTrigger_;
	float fulfillment_;
	float behaviourPersistence_;
	float hungrinessProgressRate_;
	bool isLookingForFood;

	void Start () {
		isLookingForFood = false;
		hungryTrigger_ = 30f;
		fulfillment_ = 70f;
		hungrinessProgressRate_ = 5f;
		behaviourPersistence_ = 60f; //to multiply with deltaTime to get a minute, 
		//also, this should be a dynamic value to adapt the amout of food available etc... to think
		StartCoroutine(HungerCoroutine());
	}

	void Update() {

	}

	IEnumerator HungerCoroutine () {

		while (true) {
			DecreaseHungerState (hungrinessProgressRate_);
			yield return new WaitForSeconds (1f);
		}


	}
	
	void DecreaseHungerState(float rate){
		globalHunger_ -= rate;
		if (globalHunger_ < hungryTrigger_ && !isLookingForFood ) {
			StartLookingForFood(behaviourPersistence_);
			isLookingForFood = true;
		} 
	}
	void StartLookingForFood (float persistence) {
		int timer =0;
		GetComponent<AnimalController>().setAction(new LookFor(gameObject,"Food"));
		print("I want to eat !!!");
		/*
		while ((timer * Time.deltaTime) < (persistence * Time.deltaTime) || globalHunger_>fulfillment_) {
			// action lookfor (food)
			timer +=1;
		}

		GetComponent<AnimalController>().setAction(new WalkAround(gameObject));
		*/
	}

	void StopLookingForFood() {
	}
}
