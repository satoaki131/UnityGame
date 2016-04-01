using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class TitleFontColor : MonoBehaviour {

    [SerializeField, Range(0.1f, 1.0f), Tooltip("変更時間")]
    private float _changeTime = 0.5f;

    [SerializeField, Tooltip("ランダムで出す色の設定")]
    private List<Color> _color = null;


    void Start()
    {
        StartCoroutine(ColorChange());
    }

    private IEnumerator ColorChange()
    {
        while(true)
        {
            GetComponent<Text>().color = _color[Random.Range(0, _color.Count)];
            yield return new WaitForSeconds(_changeTime);
        }
    }
}
