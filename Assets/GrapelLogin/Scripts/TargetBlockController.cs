﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ターゲットブロック（ボールが当たったら壊れるブロック）を制御する
/// ターゲットブロックの GameObject に追加して使う
/// </summary>
public class TargetBlockController : MonoBehaviour
{
    /// <summary>
    /// Collider に衝突判定があった時に呼ばれる
    /// </summary>
    /// <param name="collision">衝突の情報</param>
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Enter OnCollisionEnter2D."); // 関数が呼び出されたら Console にログを出力する

        // 衝突相手がボールだったら自分自身を破棄する
        if (collision.gameObject.tag == "Ball")
        {
            Destroy(this.gameObject);
        }
    }

    /// <summary>
    /// Collider に接触判定（トリガーモード時）があった時に呼ばれる
    /// </summary>
    /// <param name="collision">衝突の情報</param>
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter OnTriggerEnter2D."); // 関数が呼び出されたら Console にログを出力する

        // 衝突相手がボールだったら自分自身を破棄する
        if (collision.gameObject.tag == "Ball")
        {
            Destroy(this.gameObject);
        }
    }
}
