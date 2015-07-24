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
	private FatimaEvent event_;

	public AppraisalFrameImpl(FatimaEvent pevent)
	{
		event_ = pevent;
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

	/**
	 * You also need to get the list of appraisal variables
	 * */
	public List<Fatima.AppraisalVariable> getFrameContent()
	{
		return frameContent_;
	}

	/**
	 * You may also need the event that occurs this appraisal frame
	 * */
	public FatimaEvent getEvent()
	{
		return event_;
	}
}
