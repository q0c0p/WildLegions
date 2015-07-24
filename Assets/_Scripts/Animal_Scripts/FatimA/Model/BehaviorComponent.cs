using UnityEngine;
using System.Collections;
namespace Fatima
{
	/**
	 * A BehaviorComponent is used to choose the final action
	 * each components will influence the choose of the action
	 */
	public interface BehaviorComponent : Fatima.Component {
		/**
		 * this call will influence the final action to execute
		 * it will not decide the action, it some sort of a council if there is more than 
		 * one BehaviorComponent
		 */
		void actionSelection();

		/**
		 * After you choose an action you may want to access the action against who and so on 
		 * */
		Action getAction();

		/**
		 * You may also need the value according to the action 
		 * */

		float getValue();
	}
}
