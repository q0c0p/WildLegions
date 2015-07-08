

public class PlayerAttack : PlayerAction
{
	public PlayerAttack ()
	{
		setId ();
	}
	public override IPerception isPerceived()
	{
		return new PerceptionImpl(-3,4,5);
	}
}


