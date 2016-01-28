using UnityEngine;
using System.Collections;

public class MobileController : MonoBehaviour {

	public GameObject gyroReference;

	// Use this for initialization
	void Start () {
		Input.gyro.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		gyroReference.transform.rotation = Input.gyro.attitude;
	}
}
