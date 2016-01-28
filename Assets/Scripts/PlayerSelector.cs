using UnityEngine;
using System.Collections;

public class PlayerSelector : MonoBehaviour {

	GameObject PlayerObj;
	public GameObject MobileObj;
	public GameObject DesktopObj;
	public enum playerType{unassigned, mobile, desktop};
	public playerType assignType;

	Transform spawnPoint;
	public Transform MobileSpawn;
	public Transform DesktopSpawn;

	public GameObject player;

	void Start () {
		if (SystemInfo.deviceType == DeviceType.Desktop) {
			PlayerObj = DesktopObj;
			assignType = playerType.desktop;
			spawnPoint = DesktopSpawn;
		}
		if (SystemInfo.deviceType == DeviceType.Handheld) {
			PlayerObj = MobileObj;
			assignType = playerType.mobile;
			spawnPoint = MobileSpawn;
		}
		player = Instantiate (PlayerObj, spawnPoint.position, spawnPoint.rotation) as GameObject;
	}

	void Update() {
		transform.position = player.transform.position;
		transform.rotation = player.transform.rotation;
	}

	void OnDestroy() {
		Destroy (player);
	}
}