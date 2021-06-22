using System;
using System.Collections.Generic;
using UnityEngine;

public class MessageKeyEventSec11 : BaseMessageKeyEvent
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
                viewDic["a"].SetCharacterImage(EmotionType.a4, true);
                viewDic["b"].SetCharacterImage(EmotionType.b5);
                break;
            case 4:
                viewDic["b"].SetCharacterImage(EmotionType.b5, true);
                break;
            case 6:
                viewDic["b"].SetCharacterImage(EmotionType.b1);
                break;
            case 7:
                viewDic["b"].SetCharacterImage(EmotionType.b1, true);
                break;
            case 8:
                bgm.PlayBGM("love");
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                viewDic["b"].SetCharacterImage(EmotionType.Empty);
                break;
            case 9:
                viewDic["c"].SetCharacterImage(EmotionType.c5);
                viewDic["a"].SetCharacterImage(EmotionType.a1,true);
                break;
            case 10:
                viewDic["c"].SetCharacterImage(EmotionType.c4);
                break;
            case 11:
                viewDic["c"].SetCharacterImage(EmotionType.c4, true);
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                break;
            case 12:
                viewDic["c"].SetCharacterImage(EmotionType.c4);
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                break;
            case 13:
                viewDic["c"].SetCharacterImage(EmotionType.c4, true);
                viewDic["a"].SetCharacterImage(EmotionType.a7);
                break;
            case 14:
                viewDic["a"].SetCharacterImage(EmotionType.a7, true);
                break;
            case 16:
                viewDic["c"].SetCharacterImage(EmotionType.c4);
                viewDic["a"].SetCharacterImage(EmotionType.a7, true);
                break;
            case 17:
                viewDic["c"].SetCharacterImage(EmotionType.c4, true);
                viewDic["a"].SetCharacterImage(EmotionType.a7);
                break;
            case 19:
                bgm.StopBGM();
                break;
        }
    }

    public override void EffectEvent(int key, Action action, Action action2)
    {
        var fade = GameManager.Instance.gameObject.GetComponent<ScenarioFade>();
        switch (key)
        {
            case 7:
                fade.SimpleFade(2.0f, BackGroundType.Black2, action, action2);
                break;
            case 8:
                fade.WhiteFade(1.0f, BackGroundType.BehindSchoolBuilding, action, action2);
                break;
        }
    }
}