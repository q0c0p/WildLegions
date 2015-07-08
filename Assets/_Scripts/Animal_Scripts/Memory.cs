﻿using UnityEngine;
using System.Collections;

public class Memory : MonoBehaviour {
	public int sizeMax = 20;
	ArrayList actions_ = new ArrayList();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void updateMemory(IAgentAction paction)
	{
		actions_.Add (paction);
		if (actions_.Count > sizeMax) {
			actions_.RemoveAt(0); // the first element to far in the memory to have an impact to the memory
		}
		foreach ( IAgentAction action in actions_)
		{
		}
	}
	public bool isInMemory(IAgentAction paction)
	{
		foreach ( IAgentAction action in actions_)
			if(action.getId() == paction.getId())
				return true;
		return false;
	}

}
