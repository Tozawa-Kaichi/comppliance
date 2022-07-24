using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// カメラに対象を追わせるスクリプト
/// このコンポーネントはカメラに装着してください
/// </summary>
public class FollowPlayer : MonoBehaviour
{
    [Tooltip("ヒエラルキー上のカメラで追いかけたい物を対象に選んでください")]
    [SerializeField] Transform _target = default; //カメラの位置を格納するための変数
    private Vector3 _offset; // 相対座標
    private void Start()
    {
        //自分自身とtargetとの相対距離を求める
        _offset = this.transform.position - _target.position;
    }
    private void Update()
    {
        // 自分の座標にtargetの座標に相対座標を足した値を代入する
        this.transform.position = _target.position + _offset; 
    }
}
