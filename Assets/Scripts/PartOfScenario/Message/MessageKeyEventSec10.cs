using System;
using System.Collections.Generic;
using UnityEngine;

public class MessageKeyEventSec10 : BaseMessageKeyEvent
{
    [SerializeField] private CharacterView[] views;
    private ScenarioAudio audio;
    private readonly Dictionary<string, CharacterView> viewDic = new Dictionary<string, CharacterView>();

    private void Awake()
    {
        foreach (var v in views) viewDic.Add(v.name, v);
    }
    
    private void Start()
    {
        audio = GameManager.Instance.GetComponent<ScenarioAudio>();
    }

    public override void Event(int key)
    {
        switch (key)
        {
            case 0:
                viewDic["a"].SetCharacterImage(EmotionType.Empty);
                viewDic["b"].SetCharacterImage(EmotionType.Empty);
                break;
            case 1:
                viewDic["b"].SetCharacterImage(EmotionType.b3);
                break;
            case 2:
                viewDic["b"].SetCharacterImage(EmotionType.b3, true);
                break;
            case 4:
                viewDic["a"].SetCharacterImage(EmotionType.a4);
                break;
            case 5:
                viewDic["a"].SetCharacterImage(EmotionType.a4, true);
                break;
            case 7:
                break;
        }
    }

    public override void EffectEvent(int key, Action action, Action action2)
    {
        var fade = GameManager.Instance.gameObject.GetComponent<ScenarioFade>();
        switch (key)
        {
           
            
        }
    }
}