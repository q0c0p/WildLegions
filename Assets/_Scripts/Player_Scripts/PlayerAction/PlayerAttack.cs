using UnityEngine;

public class PlayerAttack : PlayerAction
{
	public PlayerAttack (GameObject go) : base(go)
	{
		event_ = new ThreatEvent (go_);
	}
}
