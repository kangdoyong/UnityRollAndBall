using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour
{
	[SerializeField] private float speed = 10;
	[SerializeField] private ThirdPersonCamera thirdPersonCamera;
	
	// Update is called once per frame
	void Update()
    {
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");

		Vector3 moveInput = new Vector3(horizontal, 0, vertical).normalized;

		// 이동할 방향을 계산
		Vector3 moveDirection = thirdPersonCamera.PlanarRotation * moveInput;
		// 캐릭터 3인칭 이동
		transform.Translate(moveDirection * speed * Time.deltaTime);
		// 캐릭터 회전
		Quaternion targetRotaion = Quaternion.LookRotation(moveDirection);
		transform.rotation = targetRotaion;
	}
}
