
namespace Fatima
{
	public interface AppraisalComponent : Fatima.Component {
		void startAppraisal(FatimaEvent evenement, AppraisalFrame aF);
		AppraisalFrame continuousAppraisal();
	}
}
