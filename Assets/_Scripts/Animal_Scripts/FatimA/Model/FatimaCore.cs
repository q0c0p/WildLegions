
namespace Fatima
{
	/**
	 * This interface is between the the AnimalController and the FAtiMA implementation.
	 * The pseudo code of FAtiMA is provided in the abstract class FatimaCoreAbstract .
	 * */
	public interface FatimaCore {
		/**
		 * The update method is call whenever the developper want .
		 * This update will update the components in FAtiMA.
		 */
		void update();
		/**
		 * This method is used to update the FAtiMA when he received an event. 
		 * This event can be several ones like received food, trigger an attack.
		 * We send this event to FAtiMA and FAtiMA will the update his state.
		 * */
		void sendEvent(FatimaEvent pevent);
		/**
		 * This Method get the Action which has been decided by the FAtiMA component
		 * It is usually called by agent controller to execuate the action
		 * */
		Action getAction();
	}
}
