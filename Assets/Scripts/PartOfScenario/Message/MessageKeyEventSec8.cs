using System;
using System.Collections.Generic;
using UnityEngine;

public class MessageKeyEventSec8 : BaseMessageKeyEvent
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
                viewDic["a"].SetCharacterImage(EmotionType.a6);
                viewDic["sa"].SetCharacterImage(EmotionType.Empty);
                viewDic["d"].SetCharacterImage(EmotionType.Empty);
                viewDic["c"].SetCharacterImage(EmotionType.Empty);
                break;
            case 1:
                viewDic["a"].SetCharacterImage(EmotionType.a6,true);
                break;
            case 2:
                viewDic["sa"].SetCharacterImage(EmotionType.sa);
                break;
            case 3:
                viewDic["sa"].SetCharacterImage(EmotionType.Empty);
                break;
            case 4:
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 5:
                viewDic["d"].SetCharacterImage(EmotionType.d4, true);
                viewDic["a"].SetCharacterImage(EmotionType.a6);
                break;
            case 6:
                viewDic["a"].SetCharacterImage(EmotionType.Empty);
                viewDic["d"].SetCharacterImage(EmotionType.Empty);
                break;
            case 7:
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 12:
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 13:
                viewDic["d"].SetCharacterImage(EmotionType.d3, true);
                break;
            case 14:
                viewDic["d"].SetCharacterImage(EmotionType.Empty);
                viewDic["c"].SetCharacterImage(EmotionType.c2);
                break;
            case 15:
                viewDic["c"].SetCharacterImage(EmotionType.c2, true);
                break;
            case 16:
                viewDic["c"].SetCharacterImage(EmotionType.c2);
                break;
            case 17:
                viewDic["c"].SetCharacterImage(EmotionType.c2, true);
                break;
            case 18:
                bgm.ChangeBGM("memory");
                audio.ShotSE("dog");
                viewDic["c"].SetCharacterImage(EmotionType.Empty);
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                break;
            case 19:
                viewDic["c"].SetCharacterImage(EmotionType.c4);
                viewDic["a"].SetCharacterImage(EmotionType.a2, true);
                break;
            case 20:
                viewDic["c"].SetCharacterImage(EmotionType.c4, true);
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                break;
            case 21:
                viewDic["c"].SetCharacterImage(EmotionType.c2);
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                break;
            case 22:
                viewDic["c"].SetCharacterImage(EmotionType.c2, true);
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                break;
            case 23:
                viewDic["c"].SetCharacterImage(EmotionType.c2);
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                break;
            case 24:
                viewDic["c"].SetCharacterImage(EmotionType.c2, true);
                viewDic["a"].SetCharacterImage(EmotionType.a6);
                break;
            case 25:
                viewDic["c"].SetCharacterImage(EmotionType.c3);
                viewDic["a"].SetCharacterImage(EmotionType.a6, true);
                break;
            case 26:
                viewDic["c"].SetCharacterImage(EmotionType.c3, true);
                viewDic["a"].SetCharacterImage(EmotionType.a7);
                break;
            case 27:
                viewDic["c"].SetCharacterImage(EmotionType.c2);
                viewDic["a"].SetCharacterImage(EmotionType.a1,true);
                break;
            case 28:
                viewDic["c"].SetCharacterImage(EmotionType.c2,true);
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                break;
            case 29:
                viewDic["c"].SetCharacterImage(EmotionType.c4);
                viewDic["a"].SetCharacterImage(EmotionType.a1,true);
                break;
            case 31:
                viewDic["c"].SetCharacterImage(EmotionType.c4,true);
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                break;
            case 32:
                viewDic["c"].SetCharacterImage(EmotionType.c6);
                viewDic["a"].SetCharacterImage(EmotionType.a1,true);
                break;
            case 33:
                viewDic["c"].SetCharacterImage(EmotionType.c6, true);
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                break;
            case 34:
                viewDic["c"].SetCharacterImage(EmotionType.c4);
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                break;
            case 35:
                viewDic["c"].SetCharacterImage(EmotionType.c5);
                break;
            case 36:
                viewDic["c"].SetCharacterImage(EmotionType.c5);
                break;
            case 37:
                viewDic["c"].SetCharacterImage(EmotionType.c5,true);
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                break;
            case 38:
                viewDic["c"].SetCharacterImage(EmotionType.c2);
                viewDic["a"].SetCharacterImage(EmotionType.a2,true);
                break;
            case 39:
                bgm.ChangeBGM("love");
                viewDic["c"].SetCharacterImage(EmotionType.c2,true);
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                break;
            case 40:
                viewDic["c"].SetCharacterImage(EmotionType.c4);
                break;
            case 41:
                viewDic["c"].SetCharacterImage(EmotionType.c4, true);
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                break;
            case 42:
                bgm.StopBGM();
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                break;


        }
    }

    public override void EffectEvent(int key, Action action, Action action2)
    {
        var fade = GameManager.Instance.gameObject.GetComponent<ScenarioFade>();
        switch (key)
        {
            case 3:
                fade.LeftFade(1.0f, BackGroundType.SchoolGate, action, action2);
                break;
            case 6:
                fade.SimpleFade(1.0f, BackGroundType.SchoolGate2, action, action2);
                break;
            case 18:
                fade.SimpleFade(2.0f, BackGroundType.Forest, action, action2);
                break;
            case 39:
                fade.WhiteFade(1.0f, BackGroundType.BehindSchoolBuilding, action, action2);
                break;
            case 42:
                fade.SimpleFade(1.0f, BackGroundType.Black2, action, action2);
                break;
        }
    }
}