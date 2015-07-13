
namespace Fatima
{
	/**
	 * AppraisalFrame is the object which store a set of AppraisalVariables
	 * and is the object between the appraisal derivation and the affect derivation process
	 */
	public interface AppraisalFrame {
		/**
		 * this function is used to tell if the AppraisalFrame has changed 
		 * since the last call of this function (the last derivation process)
		 */
		bool hasChanged();
	}
}
