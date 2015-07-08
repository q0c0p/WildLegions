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
		behaviourPersistence_ = 60f; //to multiply with deltaTime to get a minute, 
		//also, this should be a dynamic value to adapt the amout of food available etc... to think
		StartCoroutine(HungerCoroutine());
	}

	void Update() {

		//slider_.value = globalHunger_;
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
