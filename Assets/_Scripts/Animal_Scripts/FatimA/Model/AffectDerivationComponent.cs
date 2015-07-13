
namespace Fatima
{
	/**
	 *	AffectDerivation component reflect the affect derivation process in FAtiMA model
	 *	it is responsible to convert Appraisal variables (stored in the appraisalFrame) into Emotions
	 */
	public interface AffectDerivationComponent : Fatima.Component {
		/**
		 * This function is used to convert AppraisalFrame into Emotions
		 */
		Emotion affectDerivation(AppraisalFrame aF);
	}
}
