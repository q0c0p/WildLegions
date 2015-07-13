using UnityEngine;
using System.Collections;

public interface Action {
	void	playAction();
	void 	stopAction();
	FatimaEvent 	getEvent();
	long 	getId();
}

