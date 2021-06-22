using System;
using System.Collections.Generic;
using UnityEngine;

public class MessageKeyEventSec4 : BaseMessageKeyEvent
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
                viewDic["a"].SetCharacterImage(EmotionType.Empty);
                viewDic["b"].SetCharacterImage(EmotionType.Empty);
                viewDic["d"].SetCharacterImage(EmotionType.Empty);
                viewDic["sa"].SetCharacterImage(EmotionType.Empty);
                viewDic["c"].SetCharacterImage(EmotionType.Empty);
                break;
            case 1:
                viewDic["a"].SetCharacterImage(EmotionType.a3);
                break;
            case 2:
                viewDic["a"].SetCharacterImage(EmotionType.a3, true);
                viewDic["d"].SetCharacterImage(EmotionType.d1);
                break; ;
            case 3:
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                viewDic["d"].SetCharacterImage(EmotionType.d1, true);
                break; ;
            case 4:
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                break; ;
            case 5:
                viewDic["d"].SetCharacterImage(EmotionType.d1);
                break; ;
            case 6:
                viewDic["d"].SetCharacterImage(EmotionType.d2);
                break; ;
            case 7:
                viewDic["d"].SetCharacterImage(EmotionType.d1, true);
                break; ;
            case 9:
                viewDic["d"].SetCharacterImage(EmotionType.Empty);
                //暗転
                break; ;
            case 10:
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                bgm.ChangeBGM("memory");
                break;
            case 11:
                viewDic["a"].SetCharacterImage(EmotionType.a2, true);
                viewDic["b"].SetCharacterImage(EmotionType.b5);
                break;
            case 12:
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                viewDic["b"].SetCharacterImage(EmotionType.b5, true);
                break;
            case 13:
                viewDic["a"].SetCharacterImage(EmotionType.a2, true);
                viewDic["b"].SetCharacterImage(EmotionType.b2);
                break;
            case 14:
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                viewDic["b"].SetCharacterImage(EmotionType.b2, true);
                break;
            case 15:
                viewDic["a"].SetCharacterImage(EmotionType.a2, true);
                viewDic["b"].SetCharacterImage(EmotionType.b1);
                break;
            case 16:
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                viewDic["b"].SetCharacterImage(EmotionType.b1, true);
                break;
            case 17:
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                viewDic["b"].SetCharacterImage(EmotionType.b2);
                break;
            case 18:
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                viewDic["b"].SetCharacterImage(EmotionType.b2, true);
                //フェイドアウト
                break;
            case 19:
                viewDic["b"].SetCharacterImage(EmotionType.Empty);
                viewDic["c"].SetCharacterImage(EmotionType.c1);
                break;
            case 20:
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                viewDic["c"].SetCharacterImage(EmotionType.c1, true);
                break;
            case 21:
                viewDic["a"].SetCharacterImage(EmotionType.a2, true);
                viewDic["c"].SetCharacterImage(EmotionType.c3);
                break;
            case 22:
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                viewDic["c"].SetCharacterImage(EmotionType.c3, true);
                break;
            case 23:
                viewDic["a"].SetCharacterImage(EmotionType.a2, true);
                viewDic["c"].SetCharacterImage(EmotionType.c4);
                break;
            case 24:
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                viewDic["c"].SetCharacterImage(EmotionType.c4, true);
                break;
            case 25:
                viewDic["a"].SetCharacterImage(EmotionType.a7);
                break;
            case 26:
                viewDic["a"].SetCharacterImage(EmotionType.a7, true);
                viewDic["c"].SetCharacterImage(EmotionType.c2);
                break;
            case 27:
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                viewDic["c"].SetCharacterImage(EmotionType.c2, true);
                break;
            case 28:
                viewDic["a"].SetCharacterImage(EmotionType.a2, true);
                viewDic["c"].SetCharacterImage(EmotionType.c1);
                //暗転
                break;
            case 29:
                bgm.ChangeBGM("dream");
                viewDic["c"].SetCharacterImage(EmotionType.Empty);
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 30:
                viewDic["a"].SetCharacterImage(EmotionType.a7);
                viewDic["d"].SetCharacterImage(EmotionType.d3, true);
                break;
            case 31:
                viewDic["a"].SetCharacterImage(EmotionType.a7, true);
                viewDic["d"].SetCharacterImage(EmotionType.d1);
                break;
            case 32:
                viewDic["d"].SetCharacterImage(EmotionType.d1, true);
                break;
            case 36:
                viewDic["sa"].SetCharacterImage(EmotionType.sa);
                break;
            case 37:
                viewDic["sa"].SetCharacterImage(EmotionType.sa, true);
                break;
            case 38:
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                break;
            case 39:
                audio.ShotSE("gogogogo");
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                break;
            case 40:
                viewDic["a"].SetCharacterImage(EmotionType.a3);
                break;
            case 41:
                viewDic["a"].SetCharacterImage(EmotionType.a3, true);
                viewDic["d"].SetCharacterImage(EmotionType.d2);
                break;
            case 42:
                viewDic["a"].SetCharacterImage(EmotionType.a3);
                viewDic["d"].SetCharacterImage(EmotionType.d2, true);
                break;
            case 43:
                viewDic["a"].SetCharacterImage(EmotionType.a3, true);
                viewDic["d"].SetCharacterImage(EmotionType.d4);
                break;
            case 44:
                audio.StopSE();
                bgm.ChangeBGM("danger");
                viewDic["d"].SetCharacterImage(EmotionType.d4, true);
                //暗転レフト
                break;
        }
    }

    public override void EffectEvent(int key, Action action, Action action2)
    {
        var fade = GameManager.Instance.gameObject.GetComponent<ScenarioFade>();
        switch (key)
        {
            case 10:
                fade.WhiteFade(1.0f, BackGroundType.None,action, action2);
                break;
            case 19:
                fade.LeftFade(1.0f, BackGroundType.Corridor,action, action2);
                break;
            case 29:
                fade.SimpleFade(1.0f, BackGroundType.ClassRoom,action, action2);
                break;
        }
    }
}