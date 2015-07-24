using System.Collections.Generic;


namespace Fatima
{
	/**
	 * AppraisalFrame is the object which store a set of AppraisalVariables
	 * and is the object between the appraisal derivation and the affect derivation process.
	 */
	public interface AppraisalFrame {
		/**
		 * This function is used to tell if the AppraisalFrame has changed.
		 * Since the last call of this function (the last derivation process)
		 */
		bool hasChanged();
		/**
		 * We also need to add AppraisalVariables into the AppraisalFrame.
		 * This function is needed to update the state of the appraisialFrame.
		 * */
		void add(Fatima.AppraisalVariable aV);

		/**
	 	* You also need to get the list of appraisal variables
	 	* */
		List<Fatima.AppraisalVariable> getFrameContent();

		/**
		 * You may also need the event that occurs this appraisal frame
		 * */
		FatimaEvent getEvent();

	}
}
