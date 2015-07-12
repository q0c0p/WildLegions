using UnityEngine;
using System.Collections;
namespace Fatima
{
	public interface FatimaCore {
		void sendevent(FatimaEvent pevent);
		Action getAction();
	}
}
