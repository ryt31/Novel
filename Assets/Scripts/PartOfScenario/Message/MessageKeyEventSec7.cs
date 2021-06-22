using System;
using System.Collections.Generic;
using UnityEngine;

public class MessageKeyEventSec7 : BaseMessageKeyEvent
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
            case 2:
                viewDic["a"].SetCharacterImage(EmotionType.a3);
                break;
            case 3:
                audio.ShotSE("landslide");
                viewDic["d"].SetCharacterImage(EmotionType.d4);
                viewDic["a"].SetCharacterImage(EmotionType.a3, true);
                break;
            case 4:
                viewDic["d"].SetCharacterImage(EmotionType.d4, true);
                break;
            case 5:
                viewDic["d"].SetCharacterImage(EmotionType.d4);
                break;
            case 6:
                viewDic["d"].SetCharacterImage(EmotionType.d4, true);
                break;
            case 7:
                viewDic["d"].SetCharacterImage(EmotionType.d4);
                break;
        }
    }

    public override void EffectEvent(int key, Action action, Action action2)
    {
        var fade = GameManager.Instance.gameObject.GetComponent<ScenarioFade>();
        switch (key)
        {
            case 2:
                fade.LeftFade(1.0f, BackGroundType.Entrance, action, action2);
                break;
        }
    }
}