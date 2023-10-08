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

    //得点の加算
    public void AddScore(int addScore)
    {
        score += addScore;
        UpdateScoreText();
    }

    //得点の表示
    public void UpdateScoreText()
    {
        this.ScoreText.GetComponent<Text>().text = "Score : " + score;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.ScoreText = GameObject.Find("ScoreText");

        //変数の初期化、表示のクリア
        score = 0;
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {

    }
    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            // スコアを加算(追加)
            AddScore(10);
        }

        else if (other.gameObject.tag == "LargeStarTag")
        {
            // スコアを加算(追加)
            AddScore(15);
        }

        else if (other.gameObject.tag == "SmallCloudTag")
        {
            // スコアを加算(追加)
            AddScore(5);
        }

        else if (other.gameObject.tag == "LargeCloudTag")
        {
            // スコアを加算(追加)
            AddScore(20);
        }
    }
}
