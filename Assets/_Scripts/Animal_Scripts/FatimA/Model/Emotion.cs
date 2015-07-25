

namespace Fatima
{
	/** 
	 * This interface represents emotions as defined in FatiMA theory. 
	 * Emotions have an Intensity, meaning how strong it is, 
	 * and a valence which represent how positive or negative the emotion is. 
	 * */
	public interface Emotion {
		/**
	 	*Returns the emotion's intensity .
	 	* */
		float getIntensity();
		/**
	 	*Returns the emotion's valence. 
	 	* */
		float getValence();

		/**
		 * Returns the appraisalFrame that generate this emotion
		 * */
		Fatima.AppraisalFrame getAppraisalFrame();

		/**
		 * Verify if an Emotion is different of another one
		 * if the Emotion belongs to the same class than pemotion then it returns false 
		 * */

		bool isDifferent(Fatima.Emotion pemotion);
	}
}
