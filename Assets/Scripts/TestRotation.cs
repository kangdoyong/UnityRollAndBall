using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRotation : MonoBehaviour
{
	[SerializeField] private Vector3 rotation = Vector3.up;
	private void Update()
	{
		transform.Rotate(rotation * Time.deltaTime);
	}
}
