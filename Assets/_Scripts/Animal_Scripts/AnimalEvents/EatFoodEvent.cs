using UnityEngine;
using System.Collections;

public class EatFoodEvent : FatimaEventAbstract {
	public EatFoodEvent(GameObject pgo) : base()
	{
		setWhoGO (pgo);
	}
}
