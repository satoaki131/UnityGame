using UnityEngine;
using System.Collections;

public class TitleScreen : MonoBehaviour {

    public void StartButton()
    {
        FindObjectOfType<FadeManager>().SceneChange(GameScene.MENU);
    }

}
