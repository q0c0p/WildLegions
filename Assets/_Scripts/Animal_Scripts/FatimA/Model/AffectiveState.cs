
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
	}
}
