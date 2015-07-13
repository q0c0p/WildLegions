

namespace Fatima
{
	/**
	 * This interface is responsible for the memory concept in FAtiMA theory. 
	 * It should provide a way to store the events (FatimaEvents) with regards to their IDs and some way to forget them.
	 * */
	public interface Memory 
	{
		/**
		 * This method updates the memory of the agent by storing a new event.
		 * */
		void update(FatimaEvent pevent);
		/**
		 * This method allows to check if an event is already present in agent's memory.
		 * */
		bool isInMemory(FatimaEvent pevent);
	}
}



