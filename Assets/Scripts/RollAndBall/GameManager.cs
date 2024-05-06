using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager _Instance;

    public static GameManager Instance
    {
        get
        {
            // _instance�� �ִ��� null üũ�� �Ѵ�.
            if(_Instance == null)
            {
                // GameManager�� �ִ��� Ȯ���ϰ� ������ _instance�� �ʱ�ȭ �Ѵ�.
                _Instance = FindObjectOfType<GameManager>();
                if(_Instance == null)
                {
                    // ���ο� ���� ������Ʈ�� ����� �ְ� _instance�� �ʱ�ȭ �Ѵ�.
                    GameObject go = 
                    new GameObject(nameof(GameManager), typeof(GameManager));
                    _Instance = go.GetComponent<GameManager>();
                }
            }
            return _Instance;
        }
    }

    // �ʱ�ȭ
    public void Initialize()
    {
        _Instance = this;
    }

    [SerializeField] private Text stageText;
    [SerializeField] private Text scoreText;
    [SerializeField] private Button NextStageButton;
    [SerializeField] int score = 0;

    private void Start()
    {
        stageText.text = SceneManager.GetActiveScene().name;
        if (SceneManager.GetActiveScene().name == "Stage3")
        {
            NextStageButton.gameObject.SetActive(false);
        }
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdataScore();
    }

    private void UpdataScore()
    {
        scoreText.text = "���� : " + score;
    }

    public void LoadNextStage()
    {
        switch(SceneManager.GetActiveScene().name)
        {
            case "Stage1":
                SceneManager.LoadScene("Stage2");
                break;
            case "Stage2":
                SceneManager.LoadScene("Stage3");
                break;
        }
    }

    public void ReloadCurrentStage()
    {
        string stageName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(stageName);
    }

    public void GameQuit()
    {
        Application.Quit();
    }
}
