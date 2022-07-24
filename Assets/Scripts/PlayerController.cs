using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// プレイヤーの球体を操作するスクリプトです。
/// このコンポーネントはPlayerオブジェクトに装着してください。
/// </summary>
public class PlayerController : MonoBehaviour
{
    [Tooltip("これはプレイヤーの速度です")]
    [SerializeField] float _speed = default; 
    float _x = default; //横方向の入力を格納する為の変数
    float _z = default; //縦方向の入力を格納する為の変数
    Rigidbody _rigidbody = default; // 同一のGameObjectが持つRigidbodyを格納するための変数
    private void Start()
    {
        //Rigidbodyコンポーネントを取得
         _rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()//1秒間に数十回呼び出されます
    {
        //入力をFixedUpdateに書くと操作感が悪くなるのでUpdateに書きます
        //入力をｘとｚに代入
        _x = Input.GetAxis("Horizontal");
        _z = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()//秒間に呼ばれる回数が一定です
    {
        //物理挙動をUpdateに書くと動きにばらつきが発生し不自然になるのでFixedUpdateに書きます
        // rigidbodyのx軸（横）とz軸（奥）に力を加える
        _rigidbody.AddForce(_x * _speed, 0, _z * _speed);
    }
}
