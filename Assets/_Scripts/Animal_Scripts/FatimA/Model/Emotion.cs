

namespace Fatima
{
	/**
	 * This class represents emotions as defined in FatiMA theory. Emotions have an Intensity, meaning how strong it is, and a valence which represent how positive or negative the emotion is. 
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
	}
}
