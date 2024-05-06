using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
	// 카메라가 따라다닐 게임 오브젝트의 Transform
	[SerializeField] private Transform followTarget;
	// 카메라와 followTarget 사이의 z 값 거리
	[SerializeField] private float distance = 5.0f;
	private float rotationY = 0;
	private float rotationX = 0;

	// 수평 회전값을 반환하는 프로퍼티입니다.
	public Quaternion PlanarRotation 
	{ get { return Quaternion.Euler(0, rotationY, 0); } }

	void Update()
    {
		rotationY += Input.GetAxis("Mouse X");
		rotationX += Input.GetAxis("Mouse Y");

		Quaternion targetRotation = Quaternion.Euler(rotationX, rotationY,0);
		// 현재 카메라의 위치는 followTarget.position의
		// new Vector3(0, 0, distance)를 뺀 position으로 설정
		transform.position = followTarget.position - targetRotation * new Vector3(0, 0, distance);
		
		transform.rotation = targetRotation;
	}
}
