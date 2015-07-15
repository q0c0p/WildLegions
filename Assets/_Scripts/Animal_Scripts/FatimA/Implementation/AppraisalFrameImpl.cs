using UnityEngine;
using System.Collections;
using System.Collections.Generic;


/**
 * This class is an implementation of the interface 
 * AppraisalFrame this is a basic implementation if you encounter problems you can change it 
 * of course you had to implement the functions into the interface 
 * */
public class AppraisalFrameImpl : Fatima.AppraisalFrame {
	List<Fatima.AppraisalVariable> frameContent_ = new List<Fatima.AppraisalVariable>();
	private bool hasChanged_ = false;
	public AppraisalFrameImpl()
	{
	}
	/**
	 * this function return the boolean hasChanged and set it to false;
	 * */
	public bool hasChanged()
	{
		if (hasChanged_ == false)
			return hasChanged_;
		else {
			hasChanged_ = false;
			return true;
		}
	}
	/**
	 * when you add components you also need to update the hasChanged boolean
	 * */
	public void add(Fatima.AppraisalVariable aV)
	{
	hasChanged_ = true;
		frameContent_.Add (aV);
	}
}
