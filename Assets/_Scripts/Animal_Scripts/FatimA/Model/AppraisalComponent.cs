
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
		 * 
		 * */
		AppraisalFrame continuousAppraisal();
	}
}
