using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �J�����ɑΏۂ�ǂ킹��X�N���v�g
/// ���̃R���|�[�l���g�̓J�����ɑ������Ă�������
/// </summary>
public class FollowPlayer : MonoBehaviour
{
    [Tooltip("�q�G�����L�[��̃J�����Œǂ�������������ΏۂɑI��ł�������")]
    [SerializeField] Transform _target = default; //�J�����̈ʒu���i�[���邽�߂̕ϐ�
    private void Update()
    {
        // �����̍��W��target�̍��W��������
        this.transform.position = _target.position; 
    }
}
