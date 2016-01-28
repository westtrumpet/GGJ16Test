using UnityEngine;
using System.Collections;

public class DesktopController : MonoBehaviour {

	public Rigidbody playerRigid;
	public float speed;
	public float rotateSpeed;
	public PlayerSelector selector;
	float jump;
	public float jumpSpeed;
	bool grounded;

	void Start () {
		playerRigid = selector.player.GetComponent<Rigidbody> ();
	}
	
	void Update () {
		if (playerRigid.velocity.y == 0) {
			grounded = true;
		}
		float vert = Input.GetAxis ("Vertical");
		float horiz = Input.GetAxis ("Horizontal");
		if(Input.GetKeyDown(KeyCode.Space) && grounded) {
			jump = jumpSpeed;
			grounded = false;
		}
		else{
			jump = 0.0f;
		}
		Vector3 moveVel = playerRigid.transform.forward * vert * speed;
		Vector3 jumpVel = playerRigid.transform.up * jump;

		playerRigid.transform.Rotate (0.0f, horiz * rotateSpeed, 0.0f);
		playerRigid.velocity = new Vector3 (moveVel.x, playerRigid.velocity.y + jumpVel.y, moveVel.z);

	}
}
