using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private GameObject GameClearPanel;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            GameClearPanel.SetActive(true);

            // �÷��̾��� PlayerBall ������Ʈ�� ��Ȱ��ȭ�ϴ� �ڵ�
            PlayerBall playerBall = other.gameObject.GetComponent<PlayerBall>();
            playerBall.canMove = false;
        }
    }
}
