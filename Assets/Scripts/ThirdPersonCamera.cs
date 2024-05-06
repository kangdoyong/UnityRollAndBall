using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
	// ī�޶� ����ٴ� ���� ������Ʈ�� Transform
	[SerializeField] private Transform followTarget;
	// ī�޶�� followTarget ������ z �� �Ÿ�
	[SerializeField] private float distance = 5.0f;
	private float rotationY = 0;
	private float rotationX = 0;

	// ���� ȸ������ ��ȯ�ϴ� ������Ƽ�Դϴ�.
	public Quaternion PlanarRotation 
	{ get { return Quaternion.Euler(0, rotationY, 0); } }

	void Update()
    {
		rotationY += Input.GetAxis("Mouse X");
		rotationX += Input.GetAxis("Mouse Y");

		Quaternion targetRotation = Quaternion.Euler(rotationX, rotationY,0);
		// ���� ī�޶��� ��ġ�� followTarget.position��
		// new Vector3(0, 0, distance)�� �� position���� ����
		transform.position = followTarget.position - targetRotation * new Vector3(0, 0, distance);
		
		transform.rotation = targetRotation;
	}
}
