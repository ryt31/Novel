using System;
using System.Collections.Generic;
using UnityEngine;

public class MessageKeyEventSec2 : BaseMessageKeyEvent
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
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                viewDic["b"].SetCharacterImage(EmotionType.Empty);
                viewDic["d"].SetCharacterImage(EmotionType.Empty);
                viewDic["sa"].SetCharacterImage(EmotionType.Empty);
                break;
            case 1:
                viewDic["a"].SetCharacterImage(EmotionType.a2, true);
                break;
            case 4:
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 6:
                viewDic["d"].SetCharacterImage(EmotionType.d3,true);
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                break;
            case 7:
                viewDic["a"].SetCharacterImage(EmotionType.a2, true);
                break;
            case 8:
                viewDic["d"].SetCharacterImage(EmotionType.d1);
                viewDic["a"].SetCharacterImage(EmotionType.a2,true);
                break;
            case 9:
                viewDic["d"].SetCharacterImage(EmotionType.d1,true);
                break;
            case 10:
                bgm.ChangeBGM("memory");
                viewDic["b"].SetCharacterImage(EmotionType.b2);
                viewDic["d"].SetCharacterImage(EmotionType.Empty);
                break;
            case 11:
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                viewDic["b"].SetCharacterImage(EmotionType.b2,true);
                break;
            case 12:
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                viewDic["b"].SetCharacterImage(EmotionType.b2);
                break;
            case 14:
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                viewDic["b"].SetCharacterImage(EmotionType.b2, true);
                break;
            case 15:
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                viewDic["b"].SetCharacterImage(EmotionType.b1);
                break;
            case 16:
                viewDic["b"].SetCharacterImage(EmotionType.b3);
                break;
            case 17:
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                viewDic["b"].SetCharacterImage(EmotionType.b3, true);
                break;
            case 18:
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                viewDic["b"].SetCharacterImage(EmotionType.b2);
                break;
            case 19:
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                viewDic["b"].SetCharacterImage(EmotionType.b2, true);
                break;
            case 20:
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                viewDic["b"].SetCharacterImage(EmotionType.b3);
                break;
            case 21:
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                viewDic["b"].SetCharacterImage(EmotionType.b1, true);
                break;
            case 22:
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                viewDic["b"].SetCharacterImage(EmotionType.b3);
                break;
            case 23:
                viewDic["b"].SetCharacterImage(EmotionType.b1);
                break;
            case 24:
                viewDic["b"].SetCharacterImage(EmotionType.b1, true);
                viewDic["a"].SetCharacterImage(EmotionType.a7);
                break;
            case 25:
                viewDic["a"].SetCharacterImage(EmotionType.a7, true);
                viewDic["b"].SetCharacterImage(EmotionType.b3);
                break;
            case 26:
                viewDic["b"].SetCharacterImage(EmotionType.b1, true);
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                break;
            case 28:
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                viewDic["b"].SetCharacterImage(EmotionType.b2);
                break;
            case 29:
                viewDic["b"].SetCharacterImage(EmotionType.b1);
                break;
            case 30:
                viewDic["b"].SetCharacterImage(EmotionType.b1, true);
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                break;
            case 31:
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                viewDic["b"].SetCharacterImage(EmotionType.b1);
                break;
            case 32:
                viewDic["b"].SetCharacterImage(EmotionType.b1, true);
                viewDic["a"].SetCharacterImage(EmotionType.a6);
                break;
            case 33:
                bgm.ChangeBGM("dream");
                viewDic["a"].SetCharacterImage(EmotionType.a6, true);
                viewDic["b"].SetCharacterImage(EmotionType.Empty);
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 34:
                viewDic["d"].SetCharacterImage(EmotionType.d3, true);
                break;
            case 35:
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                break;
            case 36:
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 37:
                viewDic["d"].SetCharacterImage(EmotionType.d3, true);
                break;
            case 38:
                viewDic["d"].SetCharacterImage(EmotionType.d3, true);
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                break;
            case 40:
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 41:
                viewDic["d"].SetCharacterImage(EmotionType.d3, true);
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                break;
            case 42:
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 43:
                viewDic["d"].SetCharacterImage(EmotionType.d3, true);
                break;
            case 44:
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 45:
                viewDic["d"].SetCharacterImage(EmotionType.d3, true);
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                break;
            case 46:
                viewDic["a"].SetCharacterImage(EmotionType.a2, true);
                viewDic["d"].SetCharacterImage(EmotionType.d2);
                break;
            case 47:
                viewDic["a"].SetCharacterImage(EmotionType.a2, true);
                break;
            case 51:
                bgm.ChangeBGM("danger");
                viewDic["sa"].SetCharacterImage(EmotionType.sa);
                break;
            case 52:
                viewDic["sa"].SetCharacterImage(EmotionType.sa, true);
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                break;
            case 53:
                viewDic["a"].SetCharacterImage(EmotionType.a2, true);
                viewDic["d"].SetCharacterImage(EmotionType.d2);
                break;
            case 54:
                viewDic["d"].SetCharacterImage(EmotionType.d2, true);
                viewDic["sa"].SetCharacterImage(EmotionType.sa);
                break;
            case 55:
                viewDic["sa"].SetCharacterImage(EmotionType.sa, true);
                break;
            case 58:
                viewDic["d"].SetCharacterImage(EmotionType.d4);
                break;
            case 59:
                viewDic["d"].SetCharacterImage(EmotionType.d4, true);
                break;
            case 60:
                viewDic["sa"].SetCharacterImage(EmotionType.sa);
                break;
        }
    }

    public override void EffectEvent(int key, Action action, Action action2)
    {
        var fade = GameManager.Instance.gameObject.GetComponent<ScenarioFade>();
        switch (key)
        {
            case 10:
                fade.WhiteFade(1.0f, BackGroundType.Park,action, action2);
                break;
            case 16:
                fade.LeftFade(1.0f, BackGroundType.None,action, action2);
                break;
            case 33:
                fade.SimpleFade(1.0f, BackGroundType.Park,action, action2);
                break;
        }
    }
}