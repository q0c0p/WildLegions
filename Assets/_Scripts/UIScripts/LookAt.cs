using UnityEngine;
using System.Collections;

/**
 *This class is responsible to make the UI canvas (that displays info about the animal it is attached to) always face the player even if the animal is rotating. 
 */

public class LookAt : MonoBehaviour {

	public Transform target;
		
		
	void Update () 
	{
		Vector3 relativePos = target.position - transform.position;
		transform.rotation = Quaternion.LookRotation(relativePos);
	}
	
}
