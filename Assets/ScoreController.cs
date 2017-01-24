using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using UnityEngine.UI;
using System.IO;

public class ScoreController : MonoBehaviour {

	// スコアを表示するテキスト
	private GameObject scoreText;


	// スコアの種類
	private int pointLargeCloud = 20;
	private int pointSmallCloud = 10;
	private int pointLargeStar  = 20;
	private int pointSmallStar  = 10;

	// ScoreText
	private string scoreHeader = "SCORE:";

	// score
	private int score;


	// Use this for initialization
	void Start () {
		this.scoreText = GameObject.Find ("ScoreText");
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other){
		string tagName;

		try
		{
			// タグの名前取得
			tagName = other.gameObject.tag;

			// tag別にスコアを加算
			if (tagName== "LargeCloudTag") {
				score += pointLargeCloud;
			} else if (tagName == "SmallCloudTag") {
				score += pointSmallCloud;
			} else if (tagName == "LargeStarTag") {
				score += pointLargeStar;
			} else if (tagName == "SmallStarTag") {
				score += pointSmallStar;
			}

			// スコアテキストを更新
			this.scoreText.GetComponent<Text> ().text = scoreHeader + score.ToString ("00000");

		}
		catch {
		}
	}
}
