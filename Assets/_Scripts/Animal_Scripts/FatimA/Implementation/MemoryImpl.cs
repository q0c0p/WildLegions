using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Fatima;

public class MemoryImpl : Fatima.Memory {
	public int sizeMax = 20;
	List<FatimaEvent> events_ = new List<FatimaEvent>(); 
	AffectiveState affectiveState_;
	// Use this for initialization

	public void update(FatimaEvent pevent)
	{
		events_.Add (pevent);
		if (events_.Count > sizeMax) 
		{
			events_.RemoveAt(0); // the first element to far in the memory to have an impact to the memory
		}
		foreach (FatimaEvent ev in events_) 
		{
			MonoBehaviour.print(ev.getId());
		}
	}
	public bool isInMemory(FatimaEvent pevent)
	{
		foreach ( FatimaEvent ev in events_)
			if(ev.getId() == pevent.getId())
				return true;
		return false;
	}
}



