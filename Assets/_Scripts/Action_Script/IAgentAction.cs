using UnityEngine;
using System.Collections;

public interface IAgentAction {
	void playAction();
	void stopAction();
	IMovement getMovement();
	long getId();
}

