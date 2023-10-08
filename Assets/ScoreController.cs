using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    //Score変数を定義
    public int Score;
    public GameObject ScoreText;


    // Start is called before the first frame update
    void Start()
    {
        //シーン中のScoreTextオブジェクトを取得
        this.ScoreText = GameObject.Find("ScoreText");
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
            //this.ScoreText.GetComponent<Text>().text = "SCORE :" + Score;
    }
}
