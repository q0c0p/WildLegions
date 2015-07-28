using UnityEngine;
using System.Collections;

public interface NpcAnimationAdapter  {

	void Walk(bool isWalking) ;
	void Run(bool isRunning);
	void Jump();
	void Idle(bool isIdle);
	void Eat();
	void Attack();
	void Scream();
	void Dance(bool isDancing);
	void Sleep(bool isSleeping);
}
