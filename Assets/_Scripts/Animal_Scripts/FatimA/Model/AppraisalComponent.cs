
namespace Fatima
{
	/**
	 * the Appraisal Component is an object of the Appraisal Derivation process of the FAtiMA model
	 * this inteface is implemented into several objects which affect the Appraisal of an Event
	 */
	public interface AppraisalComponent : Fatima.Component {
		/**
		 * 
		 */
		void startAppraisal(FatimaEvent evenement, AppraisalFrame aF);
		AppraisalFrame continuousAppraisal();
	}
}
