using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tiredness : MonoBehaviour {

	public float globalEnergy_ = 100f;
	public Slider slider_;

	private float rate_ = 3f;

	void Start () {
		StartCoroutine (EnergyCoroutine());
	}


	void Update () {
		//slider_.value = globalEnergy_;
	}

	IEnumerator EnergyCoroutine () {
		
		while (true && globalEnergy_ >0) {
			DecreaseEnergyState (rate_);
			yield return new WaitForSeconds (2f);
		}
		
		
	}
	
	void DecreaseEnergyState(float rate){
		globalEnergy_ -= rate;

		} 
}




