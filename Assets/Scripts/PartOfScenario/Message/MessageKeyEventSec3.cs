using System;
using System.Collections.Generic;
using UnityEngine;

public class MessageKeyEventSec3 : BaseMessageKeyEvent
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
                viewDic["a"].SetCharacterImage(EmotionType.a3);
                viewDic["b"].SetCharacterImage(EmotionType.Empty);
                viewDic["d"].SetCharacterImage(EmotionType.Empty);
                viewDic["mb"].SetCharacterImage(EmotionType.Empty);
                viewDic["c"].SetCharacterImage(EmotionType.Empty);
                break;
            case 1:
                viewDic["a"].SetCharacterImage(EmotionType.a3, true);
                viewDic["d"].SetCharacterImage(EmotionType.d4);
                break;
            case 2:
                viewDic["d"].SetCharacterImage(EmotionType.d4, true);
                break;
            case 4:
                viewDic["a"].SetCharacterImage(EmotionType.a3);
                break;
            case 5:
                viewDic["a"].SetCharacterImage(EmotionType.a3, true);
                viewDic["d"].SetCharacterImage(EmotionType.d4);
                break;
            case 6:
                bgm.ChangeBGM("dream");
                viewDic["d"].SetCharacterImage(EmotionType.d4, true);
                break;
            case 7:
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 8:
                viewDic["d"].SetCharacterImage(EmotionType.d3, true);
                break;
            case 9:
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 10:
                viewDic["d"].SetCharacterImage(EmotionType.d3, true);
                break;
            case 12:
                viewDic["a"].SetCharacterImage(EmotionType.a3);
                break;
            case 13:
                viewDic["a"].SetCharacterImage(EmotionType.a3, true);
                viewDic["d"].SetCharacterImage(EmotionType.d2);
                break;
            case 14:
                viewDic["d"].SetCharacterImage(EmotionType.d3, true);
                break;
            case 16:
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                break;
            case 17:
                viewDic["a"].SetCharacterImage(EmotionType.a2, true);
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 18:
                viewDic["d"].SetCharacterImage(EmotionType.d3, true);
                break;
            case 19:
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                break;
            case 20:
                viewDic["a"].SetCharacterImage(EmotionType.a2, true);
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 21:
                viewDic["d"].SetCharacterImage(EmotionType.d3, true);
                break;
            case 22:
                viewDic["d"].SetCharacterImage(EmotionType.Empty);
                break;
            case 23:
                bgm.ChangeBGM("memory");
                viewDic["c"].SetCharacterImage(EmotionType.c1);
                break;
            case 24:
                viewDic["a"].SetCharacterImage(EmotionType.a6);
                viewDic["c"].SetCharacterImage(EmotionType.c1,true);
                break;
            case 25:
                viewDic["a"].SetCharacterImage(EmotionType.a6,true);
                viewDic["c"].SetCharacterImage(EmotionType.c2);
                break;
            case 26:
                viewDic["a"].SetCharacterImage(EmotionType.a7);
                viewDic["c"].SetCharacterImage(EmotionType.c2, true);
                break;
            case 27:
                viewDic["a"].SetCharacterImage(EmotionType.a7, true);
                viewDic["c"].SetCharacterImage(EmotionType.c1);
                break;
            case 28:
                viewDic["a"].SetCharacterImage(EmotionType.a7);
                viewDic["c"].SetCharacterImage(EmotionType.c1, true);
                break;
            case 29:
                viewDic["a"].SetCharacterImage(EmotionType.a7, true);
                viewDic["c"].SetCharacterImage(EmotionType.c3);
                break;
            case 30:
                viewDic["c"].SetCharacterImage(EmotionType.c2);
                break;
            case 31:
                viewDic["a"].SetCharacterImage(EmotionType.a7);
                viewDic["c"].SetCharacterImage(EmotionType.c2, true);
                break;
            case 32:
                viewDic["a"].SetCharacterImage(EmotionType.a7, true);
                viewDic["c"].SetCharacterImage(EmotionType.c2);
                break;
            case 33:
                bgm.ChangeBGM("dream");
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                viewDic["c"].SetCharacterImage(EmotionType.Empty);
                break;
            case 34:
                viewDic["d"].SetCharacterImage(EmotionType.d3, true);
                break;
            case 35:
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                break;
            case 37:
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                break;
            case 39:
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 40:
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                viewDic["d"].SetCharacterImage(EmotionType.d3, true);
                break;
            case 41:
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 42:
                viewDic["d"].SetCharacterImage(EmotionType.d3, true);
                break;
            case 44:
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                break;
            case 45:
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                viewDic["d"].SetCharacterImage(EmotionType.d1);
                break;
            case 46:
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                viewDic["d"].SetCharacterImage(EmotionType.d1, true);
                break;
            case 47:
                viewDic["a"].SetCharacterImage(EmotionType.a2, true);
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 48:
                viewDic["a"].SetCharacterImage(EmotionType.a7, true);
                //暗転レフト
                break;
            case 51:
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                break;
            case 52:
                viewDic["a"].SetCharacterImage(EmotionType.a2, true);
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 53:
                viewDic["d"].SetCharacterImage(EmotionType.Empty);
                //明転センター
                break;
            case 54:
                bgm.ChangeBGM("memory");
                viewDic["mb"].SetCharacterImage(EmotionType.mb);
                break;
            case 55:
                viewDic["mb"].SetCharacterImage(EmotionType.mb, true);
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                break;
            case 56:
                viewDic["mb"].SetCharacterImage(EmotionType.mb);
                viewDic["a"].SetCharacterImage(EmotionType.a2,true);
                break;
            case 57:
                viewDic["mb"].SetCharacterImage(EmotionType.mb, true);
                viewDic["a"].SetCharacterImage(EmotionType.a3);
                break;
            case 58:
                viewDic["mb"].SetCharacterImage(EmotionType.mb);
                viewDic["a"].SetCharacterImage(EmotionType.a3, true);
                break;
            case 59:
                viewDic["b"].SetCharacterImage(EmotionType.b3);
                viewDic["mb"].SetCharacterImage(EmotionType.mb, true);
                break;
            case 60:
                viewDic["b"].SetCharacterImage(EmotionType.b3, true);
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                break;
            case 61:
                viewDic["b"].SetCharacterImage(EmotionType.b3);
                viewDic["a"].SetCharacterImage(EmotionType.a2, true);
                break;
            case 62:
                viewDic["mb"].SetCharacterImage(EmotionType.mb);
                viewDic["b"].SetCharacterImage(EmotionType.b3, true);
                break;
            case 63:
                viewDic["mb"].SetCharacterImage(EmotionType.mb, true);
                viewDic["b"].SetCharacterImage(EmotionType.b3);
                break;
            case 64:
                viewDic["b"].SetCharacterImage(EmotionType.b1);
                break;
            case 65:
                viewDic["mb"].SetCharacterImage(EmotionType.mb);
                viewDic["b"].SetCharacterImage(EmotionType.b1, true);
                break;
            case 66:
                viewDic["mb"].SetCharacterImage(EmotionType.mb, true);
                viewDic["b"].SetCharacterImage(EmotionType.b5);
                break;
            case 67:
                viewDic["mb"].SetCharacterImage(EmotionType.mb);
                viewDic["b"].SetCharacterImage(EmotionType.b5, true);
                break;
            case 68:
                viewDic["mb"].SetCharacterImage(EmotionType.mb, true);
                viewDic["b"].SetCharacterImage(EmotionType.b1);
                break;
            case 69:
                viewDic["a"].SetCharacterImage(EmotionType.a7);
                viewDic["b"].SetCharacterImage(EmotionType.b1, true);
                break;
            case 70:
                viewDic["a"].SetCharacterImage(EmotionType.a7, true);
                viewDic["b"].SetCharacterImage(EmotionType.b2);
                break;
            case 71:
                viewDic["a"].SetCharacterImage(EmotionType.a6);
                viewDic["b"].SetCharacterImage(EmotionType.b2, true);
                break;
            case 72:
                viewDic["a"].SetCharacterImage(EmotionType.a6, true);
                viewDic["mb"].SetCharacterImage(EmotionType.mb);
                break;
            case 73:
                viewDic["mb"].SetCharacterImage(EmotionType.mb, true);
                viewDic["b"].SetCharacterImage(EmotionType.b3);
                viewDic["a"].SetCharacterImage(EmotionType.a4);
                //暗転
                break;
            case 74:
                bgm.ChangeBGM("dream");
                viewDic["b"].SetCharacterImage(EmotionType.Empty);
                viewDic["a"].SetCharacterImage(EmotionType.a4, true);
                viewDic["mb"].SetCharacterImage(EmotionType.Empty);
                break;
            case 76:
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 77:
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                viewDic["d"].SetCharacterImage(EmotionType.d3, true);
                break;
            case 79:
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                break;
            case 81:
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 82:
                viewDic["a"].SetCharacterImage(EmotionType.a6);
                viewDic["d"].SetCharacterImage(EmotionType.d3, true);
                break;
            case 83:
                viewDic["a"].SetCharacterImage(EmotionType.a6, true);
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 84:
                viewDic["a"].SetCharacterImage(EmotionType.a2, true);
                viewDic["d"].SetCharacterImage(EmotionType.d2);
                break;
            case 85:
                viewDic["d"].SetCharacterImage(EmotionType.d3, true);
                //暗転レフト
                break;
            case 86:
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                break;
            case 87:
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                viewDic["d"].SetCharacterImage(EmotionType.d2);
                break;
            case 88:
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                viewDic["d"].SetCharacterImage(EmotionType.d2, true);
                break;
            case 89:
                viewDic["a"].SetCharacterImage(EmotionType.a2, true);
                break;
            case 90:
                viewDic["a"].SetCharacterImage(EmotionType.a2, true);
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 91:
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                viewDic["d"].SetCharacterImage(EmotionType.d3, true);
                break;
            case 92:
                bgm.ChangeBGM("danger");
                break;
            case 93:
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                break;
        }
    }

    public override void EffectEvent(int key, Action action, Action action2)
    {
        var fade = GameManager.Instance.gameObject.GetComponent<ScenarioFade>();
        switch (key)
        {
            case 6:
                fade.LeftFade(1.0f, BackGroundType.Locker,action, action2);
                break;
            case 23:
                fade.WhiteFade(1.0f, BackGroundType.None,action, action2);
                break;
            case 33:
                fade.SimpleFade(1.0f, BackGroundType.None,action, action2);
                break;
            case 49:
                fade.LeftFade(1.0f, BackGroundType.SchoolGarden,action, action2);
                break;
            case 54:
                fade.WhiteFade(1.0f, BackGroundType.ClassRoom,action, action2);
                break;
            case 74:
                fade.SimpleFade(1.0f, BackGroundType.SchoolGarden,action, action2);
                break;
            case 86:
                fade.LeftFade(1.0f, BackGroundType.Corridor,action, action2);
                break;
        }
    }
}