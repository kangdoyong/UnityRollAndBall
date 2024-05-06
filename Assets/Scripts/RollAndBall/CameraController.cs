using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //카메라가 따라다닐 오브젝트
    [SerializeField] private Transform target;
    //카메라가 Target 포지션을 기준으로 떨어질 위치 Offset
    [SerializeField] private Vector3 offset;

    public static int count = 10;

    void Update()
    {
        //타겟의 위치를 중점으로 해서 일정 Offset 값의 거리만큼 유지한다.
        transform.position = target.position + offset;
    }
}
