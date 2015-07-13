
namespace Fatima
{
	/**
	 * The Appraisal Component is an object of the Appraisal Derivation process of the FAtiMA model
	 * This inteface is implemented into several objects which affect the Appraisal of an Event
	 * */
	public interface AppraisalComponent : Fatima.Component {
		/**
		 * This will start the appraisal process and update the appraisal Frame
		 * */
		void startAppraisal(FatimaEvent evenement, AppraisalFrame aF);
		/**
		 * continuous appraisal will update an event which is stored in memory
		 * the Agent remember but will forget after a long period of time
		 * */
		AppraisalFrame continuousAppraisal();
	}
}
