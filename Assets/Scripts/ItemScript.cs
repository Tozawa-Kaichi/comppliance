using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �A�C�e���̋������Ǘ�����X�N���v�g
/// ���̃R���|�[�l���g�̓A�C�e���ɑ������Ă�������
/// </summary>
public class ItemScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // �ڐG�Ώۂ�Player�^�O�ł����H
        if (other.CompareTag("Player"))
        {
            // ���̃R���|�[�l���g������GameObject��j������
            Destroy(gameObject);
        }
    }
}
