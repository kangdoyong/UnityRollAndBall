using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	[SerializeField] private float speed = 10;
	[SerializeField] private Vector3 targetDirection = Vector3.zero; //= new Vector3(0,0,0)
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		targetDirection = Vector3.zero;
		if (Input.GetKey(KeyCode.W))
		{
			targetDirection.z = 1;
		}
		if (Input.GetKey(KeyCode.S))
		{
			targetDirection.z = -1;
		}
		if (Input.GetKey(KeyCode.A))
		{
			targetDirection.x = -1;
		}
		if (Input.GetKey(KeyCode.D))
		{
			targetDirection.x = 1;
		}
		transform.Translate(targetDirection * speed * Time.deltaTime);
    }
}
