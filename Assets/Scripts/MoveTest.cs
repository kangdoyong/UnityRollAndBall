using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class MoveTest : MonoBehaviour
{
	// [SerializeField]를 선언하면 해당 변수가 public 변수처럼 인스펙터 창에서 수정이 가능하다
	[SerializeField] private float speed = 1f;

	[SerializeField] private float x = 5;
	[SerializeField] private float y = 5;
	[SerializeField] private float z = 5;

	[SerializeField] private Vector3 targetPosition;

	// Update is called once per frame
	void Update()
    {
		// transform.position = new Vector3(5, 5, 5);
		// 거리 = 시간 * 속력
		// Vector3.MoveTowards(현재 나의 위치, 내가 도달할 위치, 내가 움직일 속도);
		//transform.position = Vector3.MoveTowards(transform.position, new Vector3(x, y, z), speed * Time.deltaTime);
		//transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

		// new Vector3(10,0,0) = new Vector3(1,0,0) * 10;
		// 오브젝트가 우리가 원하는 방향으로 이동할려면
		// 방향백터(단위) * (속력 * 시간)(거리)
		// transform.Translate(new Vector3(1,0,0) * speed * Time.deltaTime);

		// 키보드의 입력에 따라서 방향을 얻어오는 코드
		Vector3 direction = new Vector3(0,0,0);
		if (Input.GetKey(KeyCode.W))
		{
			Debug.Log("W키를 눌렀습니다.");
			direction.z = 1;
		}
		if (Input.GetKey(KeyCode.S))
		{
			Debug.Log("S키를 눌렀습니다.");
			direction.z = -1;
		}
		if (Input.GetKey(KeyCode.A))
		{
			Debug.Log("A키를 눌렀습니다.");
			direction.x = -1;
		}
		if (Input.GetKey(KeyCode.D))
		{
			Debug.Log("D키를 눌렀습니다.");
			direction.x = 1;
		}
		transform.Translate(direction * speed * Time.deltaTime);
	}




}
