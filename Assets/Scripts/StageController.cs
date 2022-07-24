using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
/// <summary>
/// ステージの配置情報からステージを生成するスクリプト
/// </summary>
public class StageController : MonoBehaviour
{
    [Tooltip("当たってはいけない壁となるオブジェクトのプレハブを指定してください")]
    [SerializeField] GameObject _dangerBlockPrefab;
    [Tooltip("アイテムとなるオブジェクトのプレハブを指定してください")]
    [SerializeField] GameObject _itemPrefab;

    //配置情報は以下の記号で構成されなければならない
    const char BLOCK = '#';
    const char ITEM = '*';

    private Dictionary<char, GameObject> prefabMap;

    private void Start()
    {
        //キーと値を設定
        prefabMap = new Dictionary<char, GameObject>
        {
            {BLOCK, _dangerBlockPrefab},
            {ITEM, _itemPrefab},
        };
        //stage_dateというテキストファイルを配置情報として受け取る
        var textAsset = Resources.Load("stage_date") as TextAsset;
        BuildStage(textAsset.text);
    }
    void BuildStage(string stageData)//配置情報を元に配置物を生成
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
                if (obj)//もし配置情報に配置するべき物があれば
                {
                    var instance = (GameObject)Instantiate(obj, new Vector3(x, 1, z), Quaternion.identity);
                }
                x++;
            }
        }
    }
}
