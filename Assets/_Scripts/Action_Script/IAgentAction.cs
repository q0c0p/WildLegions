using UnityEngine;
using System.Collections;

public interface IAgentAction {
	void playAction();
	void stopAction();
	IMovement getMovement();
	IPerception isPerceived();
	long getId();
}

