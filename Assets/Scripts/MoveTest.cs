using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class MoveTest : MonoBehaviour
{
	// [SerializeField]�� �����ϸ� �ش� ������ public ����ó�� �ν����� â���� ������ �����ϴ�
	[SerializeField] private float speed = 1f;

	[SerializeField] private float x = 5;
	[SerializeField] private float y = 5;
	[SerializeField] private float z = 5;

	[SerializeField] private Vector3 targetPosition;

	// Update is called once per frame
	void Update()
    {
		// transform.position = new Vector3(5, 5, 5);
		// �Ÿ� = �ð� * �ӷ�
		// Vector3.MoveTowards(���� ���� ��ġ, ���� ������ ��ġ, ���� ������ �ӵ�);
		//transform.position = Vector3.MoveTowards(transform.position, new Vector3(x, y, z), speed * Time.deltaTime);
		//transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

		// new Vector3(10,0,0) = new Vector3(1,0,0) * 10;
		// ������Ʈ�� �츮�� ���ϴ� �������� �̵��ҷ���
		// �������(����) * (�ӷ� * �ð�)(�Ÿ�)
		// transform.Translate(new Vector3(1,0,0) * speed * Time.deltaTime);

		// Ű������ �Է¿� ���� ������ ������ �ڵ�
		Vector3 direction = new Vector3(0,0,0);
		if (Input.GetKey(KeyCode.W))
		{
			Debug.Log("WŰ�� �������ϴ�.");
			direction.z = 1;
		}
		if (Input.GetKey(KeyCode.S))
		{
			Debug.Log("SŰ�� �������ϴ�.");
			direction.z = -1;
		}
		if (Input.GetKey(KeyCode.A))
		{
			Debug.Log("AŰ�� �������ϴ�.");
			direction.x = -1;
		}
		if (Input.GetKey(KeyCode.D))
		{
			Debug.Log("DŰ�� �������ϴ�.");
			direction.x = 1;
		}
		transform.Translate(direction * speed * Time.deltaTime);
	}




}
