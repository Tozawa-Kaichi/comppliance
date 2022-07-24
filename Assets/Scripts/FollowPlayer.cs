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
    private Vector3 _offset; // ���΍��W
    private void Start()
    {
        //�������g��target�Ƃ̑��΋��������߂�
        _offset = this.transform.position - _target.position;
    }
    private void Update()
    {
        // �����̍��W��target�̍��W�ɑ��΍��W�𑫂����l��������
        this.transform.position = _target.position + _offset; 
    }
}
