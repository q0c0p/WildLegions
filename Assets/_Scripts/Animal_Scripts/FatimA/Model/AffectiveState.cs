using System.Collections.Generic;


namespace Fatima
{
	/**
	 * An object to store the current affective state : 
	 * it contains a set of Emotions
	 */
	public interface AffectiveState {
		/**
		 * This function add an emotion to the affective state 
		 * The Emotion is add or update
		 */
		void addEmotion(Emotion pemotion); 

		/**
		 * You may also need to get the emotions that compose actually the affective state
		 * */
		List<Fatima.Emotion> getEmotionalSet();

	}
}
