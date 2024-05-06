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

		// �̵��� ������ ���
		Vector3 moveDirection = thirdPersonCamera.PlanarRotation * moveInput;
		// ĳ���� 3��Ī �̵�
		transform.Translate(moveDirection * speed * Time.deltaTime);
		// ĳ���� ȸ��
		Quaternion targetRotaion = Quaternion.LookRotation(moveDirection);
		transform.rotation = targetRotaion;
	}
}
