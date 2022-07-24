using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// アイテムの挙動を管理するスクリプト
/// このコンポーネントはアイテムに装着してください
/// </summary>
public class ItemScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // 接触対象はPlayerタグですか？
        if (other.CompareTag("Player"))
        {
            // このコンポーネントを持つGameObjectを破棄する
            Destroy(gameObject);
        }
    }
}
