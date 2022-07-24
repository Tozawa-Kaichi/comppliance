using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// UIを管理するスクリプト
/// </summary>
public class GameController : MonoBehaviour
{
    [Tooltip("ヒエラルキー上のScoreLabelを選択してください")]
    [SerializeField] Text _scoreLabel = default;
    [Tooltip("ヒエラルキー上のWinnerLabelを選択してください")]
    [SerializeField] GameObject _winnerLabelObject = default;
    private void Update()
    {
        //シーン上のItemタグのオブジェクトの数を取得して表示
        int count = GameObject.FindGameObjectsWithTag ("Item").Length;
        _scoreLabel.text = count.ToString();
        if(count <= 0)
        {
            // オブジェクトをアクティブにする
            _winnerLabelObject.SetActive(true);
        }
    }
}
