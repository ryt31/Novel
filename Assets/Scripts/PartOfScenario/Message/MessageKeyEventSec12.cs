using System;
using System.Collections.Generic;
using UnityEngine;

public class MessageKeyEventSec12 : BaseMessageKeyEvent
{
    [SerializeField] private CharacterView[] views;
    private ScenarioAudio audio;
    private BGMControl bgm;
    private readonly Dictionary<string, CharacterView> viewDic = new Dictionary<string, CharacterView>();

    private void Awake()
    {
        foreach (var v in views) viewDic.Add(v.name, v);
    }
    
    private void Start()
    {
        audio = GameManager.Instance.GetComponent<ScenarioAudio>();
        bgm = GameManager.Instance.GetComponent<BGMControl>();
    }

    public override void Event(int key)
    {
        switch (key)
        {
            case 0:
                bgm.StopBGM();
                break;
            case 2:
                viewDic["a"].SetCharacterImage(EmotionType.a4);
                break;
            case 3:
                viewDic["b"].SetCharacterImage(EmotionType.b1);
                viewDic["a"].SetCharacterImage(EmotionType.a4, true);
                break;
            case 4:
                viewDic["b"].SetCharacterImage(EmotionType.b1, true);
                break;
            case 6:
                bgm.ChangeBGM("memory");
                viewDic["b"].SetCharacterImage(EmotionType.b2);
                break;
            case 8:
                viewDic["b"].SetCharacterImage(EmotionType.b2, true);
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                break;
            case 9:
                viewDic["b"].SetCharacterImage(EmotionType.b2);
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                break;
            case 10:
                viewDic["b"].SetCharacterImage(EmotionType.b1);
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                break;
            case 11:
                viewDic["b"].SetCharacterImage(EmotionType.b1, true);
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                break;
            case 12:
                viewDic["b"].SetCharacterImage(EmotionType.b1);
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                break;
            case 13:
                viewDic["b"].SetCharacterImage(EmotionType.b1, true);
                viewDic["a"].SetCharacterImage(EmotionType.a4);
                break;
            case 14:
                viewDic["b"].SetCharacterImage(EmotionType.b6);
                viewDic["a"].SetCharacterImage(EmotionType.a4, true);
                break;
            case 15:
                viewDic["b"].SetCharacterImage(EmotionType.b6, true);
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                break;
            case 16:
                viewDic["b"].SetCharacterImage(EmotionType.b1);
                viewDic["a"].SetCharacterImage(EmotionType.a2, true);
                break;
            case 17:
                viewDic["b"].SetCharacterImage(EmotionType.b3);
                break;
            case 18:
                viewDic["b"].SetCharacterImage(EmotionType.b3, true);
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                break;
            case 19:
                viewDic["b"].SetCharacterImage(EmotionType.b2);
                viewDic["a"].SetCharacterImage(EmotionType.a2, true);
                break;
            case 20:
                viewDic["b"].SetCharacterImage(EmotionType.b2,true);
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                break;
            case 21:
                viewDic["b"].SetCharacterImage(EmotionType.b4);
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                break;
            case 22:
                viewDic["b"].SetCharacterImage(EmotionType.b1);
                break;
            case 23:
                viewDic["b"].SetCharacterImage(EmotionType.b1, true);
                viewDic["a"].SetCharacterImage(EmotionType.a6);
                break;
            case 24:
                viewDic["b"].SetCharacterImage(EmotionType.b1);
                viewDic["a"].SetCharacterImage(EmotionType.a6, true);
                break;
            case 26:
                viewDic["b"].SetCharacterImage(EmotionType.b1, true);
                viewDic["a"].SetCharacterImage(EmotionType.a7);
                break;
            case 27:
                viewDic["b"].SetCharacterImage(EmotionType.b2);
                viewDic["a"].SetCharacterImage(EmotionType.a7, true);
                break;
            case 28:
                bgm.ChangeBGM("love");
                viewDic["b"].SetCharacterImage(EmotionType.Empty);
                viewDic["c"].SetCharacterImage(EmotionType.c6, true);
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                break;
            case 29:
                viewDic["c"].SetCharacterImage(EmotionType.c6);
                viewDic["a"].SetCharacterImage(EmotionType.a2, true);
                break;
            case 30:
                viewDic["c"].SetCharacterImage(EmotionType.c5);
                break;
            case 31:
                viewDic["c"].SetCharacterImage(EmotionType.c5, true);
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                break;
            case 32:
                viewDic["c"].SetCharacterImage(EmotionType.c4);
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                break;
            case 33:
                viewDic["c"].SetCharacterImage(EmotionType.c4, true);
                break;
            case 36:
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                break;
            case 37:
                viewDic["a"].SetCharacterImage(EmotionType.a4);
                break;
            case 38:
                viewDic["a"].SetCharacterImage(EmotionType.a4, true);
                break;
            case 40:
                viewDic["c"].SetCharacterImage(EmotionType.c6);
                break;
            case 41:
                viewDic["c"].SetCharacterImage(EmotionType.c7);
                break;
            case 42:
                viewDic["c"].SetCharacterImage(EmotionType.c8);
                break;
            case 44:
                viewDic["c"].SetCharacterImage(EmotionType.c8, true);
                viewDic["a"].SetCharacterImage(EmotionType.a4);
                break;
            case 45:
                viewDic["a"].SetCharacterImage(EmotionType.a4, true);
                break;
            case 46:
                bgm.StopBGM();
                viewDic["c"].SetCharacterImage(EmotionType.Empty);
                break;
            case 57:
                bgm.PlayBGM("happy");
                viewDic["b"].SetCharacterImage(EmotionType.b1);
                break;
            case 58:
                viewDic["b"].SetCharacterImage(EmotionType.b1, true);
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                break;
            case 59:
                viewDic["b"].SetCharacterImage(EmotionType.b2);
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                break;
            case 60:
                viewDic["b"].SetCharacterImage(EmotionType.b2, true);
                viewDic["a"].SetCharacterImage(EmotionType.a7);
                break;
            case 61:
                viewDic["b"].SetCharacterImage(EmotionType.b3);
                viewDic["a"].SetCharacterImage(EmotionType.a7, true);
                break;
            case 62:
                viewDic["b"].SetCharacterImage(EmotionType.b2);
                break;
            case 63:
                viewDic["b"].SetCharacterImage(EmotionType.b2, true);
                viewDic["a"].SetCharacterImage(EmotionType.a6);
                break;
            case 64:
                viewDic["b"].SetCharacterImage(EmotionType.b2);
                viewDic["a"].SetCharacterImage(EmotionType.a4, true);
                break;
            case 65:
                viewDic["b"].SetCharacterImage(EmotionType.b2, true);
                viewDic["a"].SetCharacterImage(EmotionType.a4);
                break;
            case 66:
                viewDic["b"].SetCharacterImage(EmotionType.b3);
                viewDic["a"].SetCharacterImage(EmotionType.a4, true);
                break;
            case 67:
                viewDic["b"].SetCharacterImage(EmotionType.b3, true);
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                break;
            case 68:
                viewDic["b"].SetCharacterImage(EmotionType.b3);
                viewDic["a"].SetCharacterImage(EmotionType.a2, true);
                break;
            case 69:
                viewDic["b"].SetCharacterImage(EmotionType.b1);
                break;
            case 70:
                viewDic["b"].SetCharacterImage(EmotionType.b1, true);
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                break;
            case 71:
                viewDic["b"].SetCharacterImage(EmotionType.b5);
                viewDic["a"].SetCharacterImage(EmotionType.a2, true);
                break;
            case 72:
                viewDic["b"].SetCharacterImage(EmotionType.b5, true);
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                break;
            case 73:
                viewDic["a"].SetCharacterImage(EmotionType.a4);
                break;
            case 74:
                viewDic["b"].SetCharacterImage(EmotionType.b1);
                viewDic["a"].SetCharacterImage(EmotionType.a4, true);
                break;
            case 75:
                viewDic["b"].SetCharacterImage(EmotionType.b1, true);
                viewDic["a"].SetCharacterImage(EmotionType.a7);
                break;
            case 76:
                viewDic["b"].SetCharacterImage(EmotionType.b1);
                viewDic["a"].SetCharacterImage(EmotionType.a6);
                break;
        }
    }

    public override void EffectEvent(int key, Action action, Action action2)
    {
        var fade = GameManager.Instance.gameObject.GetComponent<ScenarioFade>();
        switch (key)
        {
            case 6:
                fade.SimpleFade(2.0f, BackGroundType.None, action, action2);
                break;
            case 24:
                fade.LeftFade(1.0f, BackGroundType.GameCenter, action, action2);
                break;
            case 28:
                fade.WhiteFade(1.0f, BackGroundType.BehindSchoolBuilding, action, action2);
                break;
            case 46:
                fade.SimpleFade(1.0f, BackGroundType.Black2, action, action2);
                break;
            case 57:
                fade.SimpleFade(1.0f, BackGroundType.Park, action, action2);
                break;
        }
    }
}