

namespace Fatima
{
	/**
	 * AppraisalVariable is an object which is related to the event 
	 * We need to start an appraisal 
	 */
	public interface AppraisalVariable {
		/**
		 * returns the value of the intensity of this Appraisal variables
		 */
		float getValue();
		/**
		 * You may also need to set the value of the appraisalvariable
		 * */
		void setValue(float pvalue);
	}
}
