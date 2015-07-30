using UnityEngine;
using System.Collections;

public class ReceiveFoodEvent : FatimaEventAbstract {
	public ReceiveFoodEvent(GameObject pgo)
	{
		setWhoGO (pgo);
	}
}
