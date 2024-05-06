using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerBall : MonoBehaviour
{
	/// <summary>
	/// 이동 속도 변수
	/// </summary>
	[SerializeField] private float _speed = 3f;
	/// <summary>
	/// 점프 길이 변수
	/// </summary>
	[SerializeField] private float _jumpRange = 5.0f;
	/// <summary>
	/// 점프 최대 횟수
	/// </summary>
	[SerializeField] private int _maxJumpCount = 2;

	private Rigidbody _rigidbody;
	private int _jumpCount = 0;

	public bool canMove = true;
    void Start()
	{ 
        _rigidbody = GetComponent<Rigidbody>();
    }

	private void Update()
	{
		if(canMove == false)
		{
			_rigidbody.velocity = Vector3.zero;
			return;
		}
		Jump();
	}

    // Update is called once per frame
	void FixedUpdate()
    {
        if (canMove == false)
        {
            _rigidbody.velocity = Vector3.zero;
            return;
        }
        Move();
	}

	/// <summary>
	/// 캐릭터를 이동시키는 함수
	/// AddForce(이동 방향 * 속도, ForceMode.Force);
	/// </summary>
	private void Move()
	{
		float horizontal = Input.GetAxisRaw("Horizontal");
		float vertical = Input.GetAxisRaw("Vertical");
		
		 if(horizontal == 0 && vertical == 0)
		{
			_rigidbody.velocity = new Vector3(horizontal, _rigidbody.velocity.y, 0);
			return;
		}
		// Rigidbody.AddForce 함수는 특정 방향(Vector)으로 
		// 오브젝트의 힘을 가하는 함수입니다.
		_rigidbody.AddForce(new Vector3(horizontal, 0, vertical) * _speed, ForceMode.Force);
	}

	/// <summary>
	/// 캐릭터를 점프시키는 함수
	/// AddForce(점프 길이 백터, ForceMode.Impulse);
	/// </summary>
	private void Jump()
	{
		if (Input.GetButtonDown("Jump") && _jumpCount < _maxJumpCount)
		{
			_jumpCount++;
			_rigidbody.AddForce(new Vector3(0, _jumpRange, 0), ForceMode.Impulse);
		}
	}

	/// <summary>
	/// 땅이랑 부딪치면 점프 카운트를 0으로 초기화하는 함수
	/// </summary>
	/// <param name="collision"></param>
	private void OnCollisionEnter(Collision collision)
	{
		// Ground 태그로 설정된 게임 오브젝트와 충돌될 때만 
		// _jumpCount = 0으로 초기화합니다.
		if (collision.gameObject.CompareTag("Ground"))
		{
			_jumpCount = 0;
			Debug.Log("OnCollisionEnter");
		}
	}
}
