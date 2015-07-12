using UnityEngine;
using System.Collections;

namespace Fatima
{
	public interface Memory 
	{
		void update(FatimaEvent pevent);
		bool isInMemory(FatimaEvent pevent);
	}
}



