using UnityEngine;
using System.Collections;

public class Memory {
	public int sizeMax = 20;
	ArrayList actions_ = new ArrayList();
	AffectiveState affectiveState_;
	// Use this for initialization

	public void updateAction(IAgentAction paction)
	{
		actions_.Add (paction);
		if (actions_.Count > sizeMax) 
		{
			actions_.RemoveAt(0); // the first element to far in the memory to have an impact to the memory
		}
		foreach (IAgentAction action in actions_) {
			MonoBehaviour.print(action.getId());
		}
	}
	public void updateAffectiveState(AffectiveState affectiveState)
	{
		affectiveState_ = new AffectiveState ();
		affectiveState_.copy (affectiveState);
	}
	public bool isInMemory(IAgentAction paction)
	{
		foreach ( IAgentAction action in actions_)
			if(action.getId() == paction.getId())
				return true;
		return false;
	}
}



