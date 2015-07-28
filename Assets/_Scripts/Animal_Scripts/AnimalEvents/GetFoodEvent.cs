using UnityEngine;
using System.Collections;

public class GetFoodEvent : FatimaEventAbstract {

	public GetFoodEvent(GameObject other) : base()
	{
		setWhoGO (other);
	}
}
