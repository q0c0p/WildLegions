using UnityEngine;
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
		bool alreadyThere = false;
		int size = 0;
		foreach ( IAgentAction action in actions_)
		{
			if(action.getId() == paction.getId())
				alreadyThere = true;
			size++;
		}
		if(!alreadyThere)
			actions_.Add (paction);
		if (size > sizeMax) {
		}
	}

}
