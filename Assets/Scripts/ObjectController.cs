using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
	[SerializeField] private float speed = 5;
	[SerializeField] private GameObject player; // 플레이어의 게임 오브젝트
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		transform.position = Vector3.MoveTowards(transform.position, 
			player.transform.position, speed * Time.deltaTime);
    }
}
