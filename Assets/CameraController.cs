using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	
	public GameObject Butterfly;
	
	private Vector3 offset;
	
	void Start ()
	{
		offset = transform.position - Butterfly.transform.position;
	}
	
	void LateUpdate ()
	{
		transform.position = Butterfly.transform.position + offset;
	}
}