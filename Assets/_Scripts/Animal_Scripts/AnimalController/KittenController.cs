using UnityEngine;
using System.Collections;

public class KittenController : AnimalController {
	void Start()
	{
		artificialIntelligence_ = new FatimaCoreImpl (gameObject);
		anim_ = new KittenAnimationAdapterImpl (gameObject);
		action_ = new WalkAround(gameObject);
	}
}
