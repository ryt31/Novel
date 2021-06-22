using System;
using System.Collections.Generic;
using UnityEngine;

public class MessageKeyEventSec6 : BaseMessageKeyEvent
{
    [SerializeField] private CharacterView[] views;
    private ScenarioAudio audio;
    private BGMControl bgm;
    private BackGroundControl backGround;
    private readonly Dictionary<string, CharacterView> viewDic = new Dictionary<string, CharacterView>();

    private void Awake()
    {
        foreach (var v in views) viewDic.Add(v.name, v);
    }
    
    private void Start()
    {
        audio = GameManager.Instance.GetComponent<ScenarioAudio>();
        bgm = GameManager.Instance.GetComponent<BGMControl>();
        backGround = GameManager.Instance.GetComponent<BackGroundControl>();
        backGround.FindBackGround();
    }

    public override void Event(int key)
    {
        switch (key)
        {
            case 0:
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                viewDic["b"].SetCharacterImage(EmotionType.Empty);
                viewDic["d"].SetCharacterImage(EmotionType.Empty);
                viewDic["c"].SetCharacterImage(EmotionType.Empty);
                viewDic["sa"].SetCharacterImage(EmotionType.Empty);
                break;
            case 1:
                viewDic["a"].SetCharacterImage(EmotionType.a2,true);
                viewDic["d"].SetCharacterImage(EmotionType.d4);
                break;
            case 2:
                viewDic["d"].SetCharacterImage(EmotionType.d4, true);
                break;
            case 4:
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                break;
            case 5:
                viewDic["a"].SetCharacterImage(EmotionType.a2, true);
                viewDic["d"].SetCharacterImage(EmotionType.d4);
                break;
            case 6:
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                viewDic["d"].SetCharacterImage(EmotionType.d4, true);
                break;
            case 7:
                viewDic["d"].SetCharacterImage(EmotionType.d4, true);
                break;
            case 8:
                viewDic["d"].SetCharacterImage(EmotionType.d2);
                break;
            case 9:
                viewDic["a"].SetCharacterImage(EmotionType.a6);
                viewDic["d"].SetCharacterImage(EmotionType.d2, true);
                break;
            case 10:
                viewDic["a"].SetCharacterImage(EmotionType.a6, true);
                viewDic["d"].SetCharacterImage(EmotionType.Empty);
                break;
            case 12:
                bgm.ChangeBGM("bad_memory");
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                break;
            case 13:
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                viewDic["c"].SetCharacterImage(EmotionType.c9);
                break;
            case 14:
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                viewDic["c"].SetCharacterImage(EmotionType.c9, true);
                break;
            case 15:
                viewDic["a"].SetCharacterImage(EmotionType.Empty);
                viewDic["c"].SetCharacterImage(EmotionType.c4);
                break;
            case 16:
                viewDic["b"].SetCharacterImage(EmotionType.b3);
                viewDic["c"].SetCharacterImage(EmotionType.c4, true);
                break;
            case 17:
                viewDic["b"].SetCharacterImage(EmotionType.b3, true);
                viewDic["c"].SetCharacterImage(EmotionType.c4);
                break;
            case 18:
                viewDic["b"].SetCharacterImage(EmotionType.b3);
                viewDic["c"].SetCharacterImage(EmotionType.c4, true);
                break;
            case 19:
                viewDic["b"].SetCharacterImage(EmotionType.b3, true);
                viewDic["c"].SetCharacterImage(EmotionType.c4);
                break;
            case 20:
                viewDic["b"].SetCharacterImage(EmotionType.b3);
                viewDic["c"].SetCharacterImage(EmotionType.c4, true);
                break;
            case 21:
                viewDic["b"].SetCharacterImage(EmotionType.b3, true);
                viewDic["c"].SetCharacterImage(EmotionType.c4);
                break;
            case 22:
                viewDic["b"].SetCharacterImage(EmotionType.b3);
                viewDic["c"].SetCharacterImage(EmotionType.c4, true);
                break;
            case 23:
                viewDic["b"].SetCharacterImage(EmotionType.b3, true);
                viewDic["c"].SetCharacterImage(EmotionType.c4);
                break;
            case 24:
                viewDic["b"].SetCharacterImage(EmotionType.b6);
                viewDic["c"].SetCharacterImage(EmotionType.c4, true);
                break;
            case 25:
                viewDic["b"].SetCharacterImage(EmotionType.b6, true);
                viewDic["c"].SetCharacterImage(EmotionType.c2);
                break;
            case 27:
                viewDic["b"].SetCharacterImage(EmotionType.b3);
                viewDic["c"].SetCharacterImage(EmotionType.c2, true);
                break;
            case 28:
                viewDic["b"].SetCharacterImage(EmotionType.b6);
                viewDic["c"].SetCharacterImage(EmotionType.c4, true);
                break;
            case 29:
                viewDic["b"].SetCharacterImage(EmotionType.b6, true);
                viewDic["c"].SetCharacterImage(EmotionType.c4);
                break;
            case 30:
                viewDic["c"].SetCharacterImage(EmotionType.c5);
                break;
            case 32:
                bgm.StopBGM();
                viewDic["a"].SetCharacterImage(EmotionType.a5);
                viewDic["c"].SetCharacterImage(EmotionType.Empty);
                viewDic["b"].SetCharacterImage(EmotionType.Empty);
                break;
            case 33:
                viewDic["a"].SetCharacterImage(EmotionType.a7);
                break;
            case 34:
                viewDic["a"].SetCharacterImage(EmotionType.a7, true);
                break;
            case 36:
                viewDic["d"].SetCharacterImage(EmotionType.d1);
                break;
            case 37:
                viewDic["a"].SetCharacterImage(EmotionType.a7);
                viewDic["d"].SetCharacterImage(EmotionType.d1, true);
                break;
            case 38:
                viewDic["a"].SetCharacterImage(EmotionType.a7, true);
                viewDic["d"].SetCharacterImage(EmotionType.d1);
                break;
            case 40:
                viewDic["d"].SetCharacterImage(EmotionType.d1, true);
                break;
            case 42:
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 43:
                viewDic["d"].SetCharacterImage(EmotionType.d4);
                break;
            case 45:
                viewDic["a"].SetCharacterImage(EmotionType.a7);
                viewDic["d"].SetCharacterImage(EmotionType.d4, true);
                break;
            case 46:
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                viewDic["d"].SetCharacterImage(EmotionType.Empty);
                viewDic["sa"].SetCharacterImage(EmotionType.Empty);
                break;
            case 48:
                viewDic["a"].SetCharacterImage(EmotionType.a1,true);
                break;
            case 49:
                viewDic["sa"].SetCharacterImage(EmotionType.sa);
                break;
            case 50:
                viewDic["sa"].SetCharacterImage(EmotionType.sa, true);
                viewDic["d"].SetCharacterImage(EmotionType.d2);
                break;
            case 51:
                viewDic["sa"].SetCharacterImage(EmotionType.sa);
                viewDic["d"].SetCharacterImage(EmotionType.d2, true);
                break;
            case 52:
                viewDic["sa"].SetCharacterImage(EmotionType.sa, true);
                break;
            case 53:
                viewDic["d"].SetCharacterImage(EmotionType.d2);
                break;
            case 54:
                viewDic["sa"].SetCharacterImage(EmotionType.sa);
                viewDic["d"].SetCharacterImage(EmotionType.d2, true);
                break;
            case 55:
                viewDic["sa"].SetCharacterImage(EmotionType.sa, true);
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 56:
                viewDic["d"].SetCharacterImage(EmotionType.Empty);
                break;
            case 57:
                viewDic["sa"].SetCharacterImage(EmotionType.sa);
                break;
            case 61:
                viewDic["sa"].SetCharacterImage(EmotionType.sa, true);
                break;
            case 62:
                backGround.SetBackGround(BackGroundType.Black2);
                break;
            case 67:
                viewDic["a"].SetCharacterImage(EmotionType.a7);
                viewDic["sa"].SetCharacterImage(EmotionType.Empty);
                break;
            case 72:
                //エンド
                break;

        }
    }

    public override void EffectEvent(int key, Action action, Action action2)
    {
        var fade = GameManager.Instance.gameObject.GetComponent<ScenarioFade>();
        switch (key)
        {
            case 10:
                fade.LeftFade(1.0f, BackGroundType.ClassRoom, action, action2);
                break;
            case 12:
                fade.WhiteFade(1.0f, BackGroundType.None, action, action2);
                break;
            case 32:
                fade.SimpleFade(2.0f, BackGroundType.ClassRoom, action, action2);
                break;
            case 68:
                fade.WhiteFade(1.0f, BackGroundType.White2, action, action2);
                break;
        }
    }
}