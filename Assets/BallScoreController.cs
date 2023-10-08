using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScoreController : MonoBehaviour
{
    public GameObject SmallStarPrefab;
    public GameObject LargeStarPrefab;
    public GameObject SmallCloudPrefab;
    public GameObject LargeCloudPrefab;
    private int score;
    public GameObject ScoreText;

    //���_�̉��Z
    public void AddScore(int addScore)
    {
        score += addScore;
        UpdateScoreText();
    }

    //���_�̕\��
    public void UpdateScoreText()
    {
        this.ScoreText.GetComponent<Text>().text = "Score : " + score;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.ScoreText = GameObject.Find("ScoreText");

        //�ϐ��̏������A�\���̃N���A
        score = 0;
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {

    }
    //�Փˎ��ɌĂ΂��֐�
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            // �X�R�A�����Z(�ǉ�)
            AddScore(10);
        }

        else if (other.gameObject.tag == "LargeStarTag")
        {
            // �X�R�A�����Z(�ǉ�)
            AddScore(15);
        }

        else if (other.gameObject.tag == "SmallCloudTag")
        {
            // �X�R�A�����Z(�ǉ�)
            AddScore(5);
        }

        else if (other.gameObject.tag == "LargeCloudTag")
        {
            // �X�R�A�����Z(�ǉ�)
            AddScore(20);
        }
    }
}
