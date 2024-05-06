using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathZone : MonoBehaviour
{
    [SerializeField] private GameObject GameOverPanel;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            GameOverPanel.SetActive(true);

            PlayerBall playerBall = other.gameObject.GetComponent<PlayerBall>();
            playerBall.canMove = false;
        }
    }
}
