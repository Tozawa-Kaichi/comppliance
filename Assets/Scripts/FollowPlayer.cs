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
    private void Update()
    {
        // 自分の座標にtargetの座標を代入する
        this.transform.position = _target.position; 
    }
}
