using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    //Score�ϐ����`
    public int Score;
    public GameObject ScoreText;


    // Start is called before the first frame update
    void Start()
    {
        //�V�[������ScoreText�I�u�W�F�N�g���擾
        this.ScoreText = GameObject.Find("ScoreText");
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
            //this.ScoreText.GetComponent<Text>().text = "SCORE :" + Score;
    }
}
