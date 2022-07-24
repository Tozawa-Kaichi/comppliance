using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
/// <summary>
/// �X�e�[�W�̔z�u��񂩂�X�e�[�W�𐶐�����X�N���v�g
/// </summary>
public class StageController : MonoBehaviour
{
    [Tooltip("�������Ă͂����Ȃ��ǂƂȂ�I�u�W�F�N�g�̃v���n�u���w�肵�Ă�������")]
    [SerializeField] GameObject _dangerBlockPrefab;
    [Tooltip("�A�C�e���ƂȂ�I�u�W�F�N�g�̃v���n�u���w�肵�Ă�������")]
    [SerializeField] GameObject _itemPrefab;

    //�z�u���͈ȉ��̋L���ō\������Ȃ���΂Ȃ�Ȃ�
    const char BLOCK = '#';
    const char ITEM = '*';

    private Dictionary<char, GameObject> prefabMap;

    private void Start()
    {
        //�L�[�ƒl��ݒ�
        prefabMap = new Dictionary<char, GameObject>
        {
            {BLOCK, _dangerBlockPrefab},
            {ITEM, _itemPrefab},
        };
        //stage_date�Ƃ����e�L�X�g�t�@�C����z�u���Ƃ��Ď󂯎��
        var textAsset = Resources.Load("stage_date") as TextAsset;
        BuildStage(textAsset.text);
    }
    void BuildStage(string stageData)//�z�u�������ɔz�u���𐶐�
    {
        var lines = stageData.Split('\n');
        int z = lines.Count();
        foreach (var line in lines)
        {
            z--;
            int x = 0;
            foreach (var ch in line)
            {
                GameObject obj;
                prefabMap.TryGetValue(ch, out obj);
                if (obj)//�����z�u���ɔz�u����ׂ����������
                {
                    var instance = (GameObject)Instantiate(obj, new Vector3(x, 1, z), Quaternion.identity);
                }
                x++;
            }
        }
    }
}
