using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCode : MonoBehaviour
{
	// 유니티 엔진 게임내에 있는 스크립트(코드)를 컴파일할 때
	// 호출되는 함수
	// 게임 내에 있는 코드들을 초기화할 때
	private void Awake()
	{
		Debug.Log("유니티 엔진 게임내에 있는 스크립트(코드)를 컴파일할 때 호출되는 Awake 함수");
	}

	// 게임 오브젝트가 켜질때 호출되는 함수
	// 게임을 시작할 때 게임 오브젝트가 켜져 있어도 호출된다.
	private void OnEnable()
	{
		Debug.Log("게임 오브젝트가 켜질때 호출되는 OnEnable 함수");
	}

	// 게임 오브젝트가 꺼질때 호출되는 함수
	// 게임이 종료될 때 한번 더 호출됩니다.
	// 오브젝트가 파괴될 때 한번 더 호출됩니다.
	private void OnDisable()
	{
		Debug.Log("게임 오브젝트가 꺼질때 호출되는 OnDisable 함수");
	}

	// 게임 내에서 오브젝트가 삭제될때(파괴될때) 호출되는 함수
	// 게임이 종료될 때 한번 더 호출됩니다.
	private void OnDestroy()
	{
		Debug.Log("게임 내에서 오브젝트가 삭제될때(파괴될때) 호출되는 OnDestroy 함수");
	}

	// 게임이 시작 될때 호출 되는 함수
	// 게임 내에 있는 데이터를 불러올 때
	// 서버에 있는 데이터를 불러올때
	private void Start()
	{
		Debug.Log("게임이 시작 될때 호출 되는 Start 함수");
	}

	// 우리가 정한 시간과 프레임에 따라서 일정 주기로 호출되는 함수
	// 컴퓨터 성능에 따라 달리 호출되지 않도록 일정 주기마다 호출되게 
	// FixedUpdate함수를 만들었습니다.
	// 물리연산, 일정 주기마다 호출이 되야하는 코드
	private void FixedUpdate()
	{
		Debug.Log("우리가 정한 시간과 프레임에 따라서 일정 주기로 호출되는 FixedUpdate 함수");
	}

	// 컴퓨터의 CPU에 영향을 받아서 호출되는 빈도가 달라집니다.
	// 매 프레임마다 호출 되는 함수
	// 기본적인 게임 로직, 아이템 강화, 합성,혼자서 하는 게임
	private void Update()
	{
		Debug.Log("매 프레임 마다 호출되는 Update 함수");
	}

	// Update 함수가 호출되고 나서 호출되는 함수
	// 게임의 이펙트, 연출 처리
	// 게임내의 재화, 아이템들을 먼저 저장하거나 처리하고 다음에 이펙트를 뿌려야 하기 때문에
	// 게임의 이펙트, 연출 처리를 LateUpdate에서 처리합니다.
	private void LateUpdate()
	{
		Debug.Log("Update 함수가 호출되고 나서 호출되는 LateUpdate 함수");
	}


}
