using UnityEngine;
using System.Collections;

public class AppraisalVariableAbstract : Fatima.AppraisalVariable {
	private float value_;
	public virtual float getValue(){
		return value_;
	}
	protected virtual void setValue(float value){
		value_ = value;
	}
}
