using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// 障害物となる壁の挙動を操作するスクリプト
/// DangerWallに付けてください
/// </summary>
public class DangerWallScript : MonoBehaviour
{
    [Tooltip("追加した演出が終わるまでの秒数に調整してください")]
    [SerializeField] float _waitsecond;//ロード開始まで待つ秒数
    int _sceneIndex = default; //現在のシーンのインデックス番号を格納するための変数
    private void Start()
    {
        // 現在のシーン番号を取得
        _sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
    private void OnCollisionEnter(Collision collision)
    {
        // 接触したオブジェクトのタグが"Player"の場合
        if (collision.gameObject.CompareTag("Player"))
        {
            //演出が追加される可能性を考慮して非同期で待つ
            StartCoroutine( LoadScene(_sceneIndex));
            Destroy(collision.gameObject);//当たったプレイヤーをデストロイ
        }
    }
    public IEnumerator LoadScene(int index)
    {
        yield return new WaitForSeconds(_waitsecond);//指定した秒数待ってくれる
        // 現在のシーンを再読込する
        SceneManager.LoadScene(index);
    }

}
