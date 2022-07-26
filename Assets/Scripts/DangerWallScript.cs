using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// ��Q���ƂȂ�ǂ̋����𑀍삷��X�N���v�g
/// DangerWall�ɕt���Ă�������
/// </summary>
public class DangerWallScript : MonoBehaviour
{
    [Tooltip("�ǉ��������o���I���܂ł̕b���ɒ������Ă�������")]
    [SerializeField] float _waitsecond;//���[�h�J�n�܂ő҂b��
    int _sceneIndex = default; //���݂̃V�[���̃C���f�b�N�X�ԍ����i�[���邽�߂̕ϐ�
    private void Start()
    {
        // ���݂̃V�[���ԍ����擾
        _sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
    private void OnCollisionEnter(Collision collision)
    {
        // �ڐG�����I�u�W�F�N�g�̃^�O��"Player"�̏ꍇ
        if (collision.gameObject.CompareTag("Player"))
        {
            //���o���ǉ������\�����l�����Ĕ񓯊��ő҂�
            StartCoroutine( LoadScene(_sceneIndex));
            Destroy(collision.gameObject);//���������v���C���[���f�X�g���C
        }
    }
    public IEnumerator LoadScene(int index)
    {
        yield return new WaitForSeconds(_waitsecond);//�w�肵���b���҂��Ă����
        // ���݂̃V�[�����ēǍ�����
        SceneManager.LoadScene(index);
    }

}
