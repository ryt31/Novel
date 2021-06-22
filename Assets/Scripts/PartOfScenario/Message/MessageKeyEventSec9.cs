using System;
using System.Collections.Generic;
using UnityEngine;

public class MessageKeyEventSec9 : BaseMessageKeyEvent
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
                viewDic["a"].SetCharacterImage(EmotionType.a4);
                viewDic["d"].SetCharacterImage(EmotionType.Empty);
                break;
            case 1:
                viewDic["d"].SetCharacterImage(EmotionType.d4);
                viewDic["a"].SetCharacterImage(EmotionType.a4,true);
                break;
            case 2:
                viewDic["d"].SetCharacterImage(EmotionType.d4, true);
                break;
            case 4:
                viewDic["a"].SetCharacterImage(EmotionType.a4);
                break;
            case 5:
                viewDic["a"].SetCharacterImage(EmotionType.a4, true);
                break;
            case 6:
                bgm.ChangeBGM("dream");
                viewDic["d"].SetCharacterImage(EmotionType.d3);
                break;
            case 8:
                viewDic["d"].SetCharacterImage(EmotionType.d3, true);
                break;
            case 10:
                viewDic["d"].SetCharacterImage(EmotionType.d3, true);
                viewDic["a"].SetCharacterImage(EmotionType.a4);
                break;
            case 11:
                viewDic["a"].SetCharacterImage(EmotionType.a4, true);
                break;
            case 12:
                bgm.StopBGM();
                break;
            case 15:
                viewDic["a"].SetCharacterImage(EmotionType.a1);
                break;
            case 16:
                bgm.PlayBGM("last");
                viewDic["a"].SetCharacterImage(EmotionType.a1, true);
                break;
        }
    }

    public override void EffectEvent(int key, Action action, Action action2)
    {
        var fade = GameManager.Instance.gameObject.GetComponent<ScenarioFade>();
        switch (key)
        {
            case 12:
                fade.SimpleFade(1.0f, BackGroundType.SchoolGarden, action, action2);
                break;
        }
    }
}