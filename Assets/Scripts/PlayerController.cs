using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �v���C���[�̋��̂𑀍삷��X�N���v�g�ł��B
/// ���̃R���|�[�l���g��Player�I�u�W�F�N�g�ɑ������Ă��������B
/// </summary>
public class PlayerController : MonoBehaviour
{
    [Tooltip("����̓v���C���[�̑��x�ł�")]
    [SerializeField] float _speed = default; 
    float _x = default; //�������̓��͂��i�[����ׂ̕ϐ�
    float _z = default; //�c�����̓��͂��i�[����ׂ̕ϐ�
    Rigidbody _rigidbody = default; // �����GameObject������Rigidbody���i�[���邽�߂̕ϐ�
    private void Start()
    {
        //Rigidbody�R���|�[�l���g���擾
         _rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()//1�b�Ԃɐ��\��Ăяo����܂�
    {
        //���͂�FixedUpdate�ɏ����Ƒ��슴�������Ȃ�̂�Update�ɏ����܂�
        //���͂����Ƃ��ɑ��
        _x = Input.GetAxis("Horizontal");
        _z = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()//�b�ԂɌĂ΂��񐔂����ł�
    {
        //����������Update�ɏ����Ɠ����ɂ΂�����������s���R�ɂȂ�̂�FixedUpdate�ɏ����܂�
        // rigidbody��x���i���j��z���i���j�ɗ͂�������
        _rigidbody.AddForce(_x * _speed, 0, _z * _speed);
    }
}
