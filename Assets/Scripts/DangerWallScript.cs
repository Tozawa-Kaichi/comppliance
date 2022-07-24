using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DangerWallScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // �ڐG�����I�u�W�F�N�g�̃^�O��"Player"�̏ꍇ
        if (collision.gameObject.CompareTag("Player"))
        {
            // ���݂̃V�[���ԍ����擾
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            // ���݂̃V�[�����ēǍ�����
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
