﻿
namespace Fatima
{
	/**
	 * This interface is extended by every FAtiMA component like AppraisalComponent and AffectDerivationComponent, and maybe other components later.
	 * Each component must be updated as an event is perceived by the agent.
	 * */
	public interface Component {
		/**
	 	*This method updates the designated component. 
	 	* */
		void update();
		/**
	 	*This method updates the designated component and takes an event as argument. 
	 	* */
		void update(FatimaEvent pevent);
	}
}
