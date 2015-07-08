


public class PlayerFeed : PlayerAction
{
	public PlayerFeed()
	{
		setId ();
	}
	public override IPerception isPerceived()
	{
		return new PerceptionImpl(6,-5,-5);
	}
}