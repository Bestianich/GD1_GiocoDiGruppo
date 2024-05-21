using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControllerScript : MonoBehaviour {
	public GameObject[] DanbocchiObject;
	public GameObject[] DoorObject;
	public GameObject[] FrontPanelObject;
	public GameObject[] RightPanelObject;
	public GameObject[] LeftPanelObject;
	public GameObject[] RearPanelObject;
	public GameObject[] RoofPanelObject;
	public GameObject[] SilencerObject;

	private bool rotateFlag = false;
	private bool doorFlag = false;
	private bool panelFlag = false;
	private float speed = 0.02f;
	private float dt, pt;
	private Vector3[] frontPanelPos;
	private Vector3[] rightPanelPos;
	private Vector3[] leftPanelPos;
	private Vector3[] rearPanelPos;
	private Vector3[] roofPanelPos;
	private Vector3[] silencerPos;
	private int danbocchiModel = 0;

	// Use this for initialization
	void Start () {
		dt = 1f;
		pt = 1f;
		frontPanelPos = new Vector3[DanbocchiObject.Length];
		rightPanelPos = new Vector3[DanbocchiObject.Length];
		leftPanelPos = new Vector3[DanbocchiObject.Length];
		rearPanelPos = new Vector3[DanbocchiObject.Length];
		roofPanelPos = new Vector3[DanbocchiObject.Length];
		silencerPos = new Vector3[DanbocchiObject.Length];
		for (int i = 0; i < DanbocchiObject.Length; i++) {
			frontPanelPos[i] = FrontPanelObject[i].transform.localPosition;
			rightPanelPos[i] = RightPanelObject[i].transform.localPosition;
			leftPanelPos[i] = LeftPanelObject[i].transform.localPosition;
			rearPanelPos[i] = RearPanelObject[i].transform.localPosition;
			roofPanelPos[i] = RoofPanelObject[i].transform.localPosition;
			silencerPos[i] = SilencerObject[i].transform.localPosition;
		}
		foreach (var danbocchi in DanbocchiObject) {
			danbocchi.SetActive (false);
		}
		DanbocchiObject [danbocchiModel].SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		dt += speed;
		Mathf.Clamp01 (dt);
		float doorAngle;
		if (doorFlag) {
			doorAngle = Mathf.LerpAngle (0f, 120f, dt);
		} else {
			doorAngle = Mathf.LerpAngle (120f, 0f, dt);
		}
		foreach (var door in DoorObject) {
			door.transform.localEulerAngles = new Vector3 (0, doorAngle, 0);
		}

		if (rotateFlag) {
			foreach (var danbocchi in DanbocchiObject) {
				danbocchi.transform.Rotate (new Vector3 (0, 30, 0) * Time.deltaTime);
			}
		}

		pt += speed;
		Mathf.Clamp01 (pt);
		float panelDistance;
		if (panelFlag) {
			panelDistance = Mathf.Lerp (0f, 0.2f, pt);
		} else {
			panelDistance = Mathf.Lerp (0.2f, 0f, pt);
		}
		for (int i = 0; i < DanbocchiObject.Length; i++) {
			FrontPanelObject[i].transform.localPosition = new Vector3 (frontPanelPos[i].x, frontPanelPos[i].y, frontPanelPos[i].z - panelDistance);
			RightPanelObject[i].transform.localPosition = new Vector3 (rightPanelPos[i].x + panelDistance, rightPanelPos[i].y, rightPanelPos[i].z);
			LeftPanelObject[i].transform.localPosition = new Vector3 (leftPanelPos[i].x - panelDistance, leftPanelPos[i].y, leftPanelPos[i].z);
			RearPanelObject[i].transform.localPosition = new Vector3 (rearPanelPos[i].x, rearPanelPos[i].y, rearPanelPos[i].z + panelDistance);
			RoofPanelObject[i].transform.localPosition = new Vector3 (roofPanelPos[i].x, roofPanelPos[i].y + panelDistance, roofPanelPos[i].z);
			SilencerObject[i].transform.localPosition = new Vector3 (silencerPos[i].x, silencerPos[i].y + (panelDistance * 2f), silencerPos[i].z);
		}
	}

	public void OnDoorButton () {
		dt = 0f;
		doorFlag = !doorFlag;
	}

	public void OnRotateButton() {
		rotateFlag = !rotateFlag;
	}

	public void OnAssembleButton() {
		pt = 0f;
		panelFlag = !panelFlag;
	}

	public void OnChangeModel() {
		danbocchiModel++;
		if (danbocchiModel >= DanbocchiObject.Length) {
			danbocchiModel = 0;
		}
		foreach (var danbocchi in DanbocchiObject) {
			danbocchi.SetActive (false);
		}
		DanbocchiObject [danbocchiModel].SetActive (true);
	}
}
