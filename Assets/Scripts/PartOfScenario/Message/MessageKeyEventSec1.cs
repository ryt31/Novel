using System;
using System.Collections.Generic;
using UnityEngine;

public class MessageKeyEventSec1 : BaseMessageKeyEvent
{
    [SerializeField] private CharacterView[] views;
    private BGMControl bgm;
    private ScenarioAudio audio;
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
                viewDic["s"].SetCharacterImage(EmotionType.sb);
                viewDic["a"].SetCharacterImage(EmotionType.Empty);
                viewDic["d"].SetCharacterImage(EmotionType.Empty);
                break;
            case 4:
                viewDic["s"].SetCharacterImage(EmotionType.Empty);
                break;
            case 6:
                viewDic["s"].SetCharacterImage(EmotionType.sd);
                break;
            case 7:
                viewDic["s"].SetCharacterImage(EmotionType.sd,true);
                break;
            case 8:
                viewDic["s"].SetCharacterImage(EmotionType.Empty);
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 9:
                viewDic["d"].SetCharacterImage(EmotionType.d3,true);
                break;
            case 10:
                bgm.PlayBGM("dream");
                break;
            case 12:
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 13:
                viewDic["d"].SetCharacterImage(EmotionType.d3,true);
                break;
            case 15:
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 16:
                viewDic["d"].SetCharacterImage(EmotionType.d3,true);
                break;
            case 17:
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 18:
                viewDic["d"].SetCharacterImage(EmotionType.d3,true);
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                break;
            case 19:
                viewDic["a"].SetCharacterImage(EmotionType.a2,true);
                break;
            case 20:
                viewDic["d"].SetCharacterImage(EmotionType.d2);
                break;
            case 21:
                viewDic["d"].SetCharacterImage(EmotionType.d2,true);
                break;
            case 22:
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                break;
            case 23:
                viewDic["a"].SetCharacterImage(EmotionType.a2,true);
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 24:
                viewDic["d"].SetCharacterImage(EmotionType.d3,true);
                break;
            case 25:
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                break;
            case 26:
                viewDic["a"].SetCharacterImage(EmotionType.a2,true);
                break;
            case 27:
                viewDic["d"].SetCharacterImage(EmotionType.d2);
                break;
            case 28:
                viewDic["d"].SetCharacterImage(EmotionType.d2,true);
                break;
            case 29:
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 30:
                viewDic["d"].SetCharacterImage(EmotionType.d3,true);
                viewDic["a"].SetCharacterImage(EmotionType.a2);
                break;
            case 31:
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                viewDic["a"].SetCharacterImage(EmotionType.a2,true);
                break;
            case 32:
                viewDic["d"].SetCharacterImage(EmotionType.d3,true);
                break;
            case 33:
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 34:
                viewDic["d"].SetCharacterImage(EmotionType.d3,true);
                viewDic["a"].SetCharacterImage(EmotionType.a5);
                break;
            case 35:
                viewDic["a"].SetCharacterImage(EmotionType.a5,true);
                break;
            case 36:
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 37:
                viewDic["d"].SetCharacterImage(EmotionType.d3,true);
                break;
            case 40:
                viewDic["d"].SetCharacterImage(EmotionType.d1);
                break;
            case 41:
                viewDic["d"].SetCharacterImage(EmotionType.d1,true);
                break;
        }
    }

    public override void EffectEvent(int key, Action action, Action action2)
    {
        var fade = GameManager.Instance.gameObject.GetComponent<ScenarioFade>();
        switch (key)
        {
            case 4:
                fade.SimpleFade(1.0f, BackGroundType.Black,action, action2);
                break;
            case 9:
                fade.SimpleFade(1.0f, BackGroundType.Forest,action, action2);
                break;
        }
    }
}