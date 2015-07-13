﻿
/**
 * This class is not part of the FAtiMA core model, however it useful to have an interface responsible for events that the FAtiMA model can handle. 
 * Such an event basically answers two questions : What (getAction) and somehow Is it new (id) to make sure the same event is not taken in account several times. 
 * */
public interface FatimaEvent 
{
	/**
	 * This method returns the Action that occurs in the agent's perception zone.
	 * */
	Action getAction();
	/**
	 * This method returns the ID of the Action that occurs in the agent's perception zone.
	 * */
	int getId();
}
