using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// UI���Ǘ�����X�N���v�g
/// </summary>
public class GameController : MonoBehaviour
{
    [Tooltip("�q�G�����L�[���ScoreLabel��I�����Ă�������")]
    [SerializeField] Text _scoreLabel = default;
    [Tooltip("�q�G�����L�[���WinnerLabel��I�����Ă�������")]
    [SerializeField] GameObject _winnerLabelObject = default;
    private void Update()
    {
        //�V�[�����Item�^�O�̃I�u�W�F�N�g�̐����擾���ĕ\��
        int count = GameObject.FindGameObjectsWithTag ("Item").Length;
        _scoreLabel.text = count.ToString();
        if(count <= 0)
        {
            // �I�u�W�F�N�g���A�N�e�B�u�ɂ���
            _winnerLabelObject.SetActive(true);
        }
    }
}
