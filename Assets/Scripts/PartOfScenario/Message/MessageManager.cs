﻿using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.UI;

/*
 * Unity で、1文字ずつ表示するためのコード
 */
public class MessageManager : MonoBehaviour
{
    public Text text;

    //*******************************************************************
    //                情報と基本メソッド
    //*******************************************************************
    public float writeSpeed = 0.1f;

    /// 書くスピード(短いほど早い)
    public bool isWriting;

    /// 書いている途中かどうか

    private readonly TextLoader textLoader = new TextLoader();
    private MessageKey messageKey; // 文章の番号は Keyオブジェクト で表す
    private BaseMessageKeyEvent keyEvent;
    public BaseMessageKeyEvent KeyEvent
    {
        get => keyEvent;
    }
    private GameManager gameManager;
    private Dictionary<int, string> messages;
    private Coroutine modalRoutine = null;
    private Choice choice;
    private bool isChoice = false;

    private void Start()
    {
        gameManager = GameManager.Instance; // ゲームマネージャ取得

        gameManager.CurrentState
            .Subscribe(state => { Messages(state); }).AddTo(gameObject);

        gameManager.IsStartScenario
            .Where(isStartScenario => isStartScenario)
            .Subscribe(_ =>
            {
                Write(messages[messageKey.Key]);
                keyEvent.Event(messageKey.Key);
                messageKey.Next();
            }).AddTo(gameObject);
        Clean();
        this.UpdateAsObservable()
            .Where(_ => Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.Space))
            .ThrottleFirst(TimeSpan.FromSeconds(0.2f))
            .Subscribe(_ =>
            {
                OnClick();
            }).AddTo(gameObject);
    }

    /// テキストを書くメソッド
    private void Write(string s)
    {
        //毎回、書くスピードを 0.2 に戻す------<戻したくない場合はここを消す>
        writeSpeed = 0.1f;
        StartCoroutine(WriteRoutine(s));
    }

    /// 書くためのコルーチン
    private IEnumerator WriteRoutine(string s)
    {
        //書いている途中の状態にする
        isWriting = true;
        //渡されたstringの文字の数だけループ
        for (var i = 0; i < s.Length; i++)
        {
            //テキストにi番目の文字を付け足して表示する
            text.text += s.Substring(i, 1);
            //次の文字を表示するまで少し待つ
            yield return new WaitForSeconds(writeSpeed);
        }

        //書いている途中の状態を解除する
        isWriting = false;
    }

    /// テキストを消すメソッド
    private void Clean()
    {
        text.text = "";
    }

    private void Messages(GameState state)
    {
        messageKey = new MessageKey();
        switch (state)
        {
            case GameState.Sec1:
                keyEvent = GameObject.FindWithTag("MessageKeyEventManager").GetComponent<MessageKeyEventSec1>();
                messages = textLoader.LoadTextAsDic(TextPath.Sec1());
                break;
            case GameState.Sec2:
                keyEvent = GameObject.FindWithTag("MessageKeyEventManager").GetComponent<MessageKeyEventSec2>();
                messages = textLoader.LoadTextAsDic(TextPath.Sec2());
                break;
            case GameState.Sec3:
                keyEvent = GameObject.FindWithTag("MessageKeyEventManager").GetComponent<MessageKeyEventSec3>();
                messages = textLoader.LoadTextAsDic(TextPath.Sec3());
                break;
            case GameState.Sec4:
                keyEvent = GameObject.FindWithTag("MessageKeyEventManager").GetComponent<MessageKeyEventSec4>();
                messages = textLoader.LoadTextAsDic(TextPath.Sec4());
                break;
            case GameState.Sec5:
                keyEvent = GameObject.FindWithTag("MessageKeyEventManager").GetComponent<MessageKeyEventSec5>();
                messages = textLoader.LoadTextAsDic(TextPath.Sec5());
                break;
            case GameState.Sec6:
                keyEvent = GameObject.FindWithTag("MessageKeyEventManager").GetComponent<MessageKeyEventSec6>();
                messages = textLoader.LoadTextAsDic(TextPath.Sec6());
                break;
            case GameState.Sec7:
                keyEvent = GameObject.FindWithTag("MessageKeyEventManager").GetComponent<MessageKeyEventSec7>();
                messages = textLoader.LoadTextAsDic(TextPath.Sec7());
                break;
            case GameState.Sec8:
                keyEvent = GameObject.FindWithTag("MessageKeyEventManager").GetComponent<MessageKeyEventSec8>();
                messages = textLoader.LoadTextAsDic(TextPath.Sec8());
                break;
            case GameState.Sec9:
                keyEvent = GameObject.FindWithTag("MessageKeyEventManager").GetComponent<MessageKeyEventSec9>();
                messages = textLoader.LoadTextAsDic(TextPath.Sec9());
                break;
            case GameState.Sec10:
                keyEvent = GameObject.FindWithTag("MessageKeyEventManager").GetComponent<MessageKeyEventSec10>();
                messages = textLoader.LoadTextAsDic(TextPath.Sec10());
                break;
            case GameState.Sec11:
                keyEvent = GameObject.FindWithTag("MessageKeyEventManager").GetComponent<MessageKeyEventSec11>();
                messages = textLoader.LoadTextAsDic(TextPath.Sec11());
                break;
            case GameState.Sec12:
                keyEvent = GameObject.FindWithTag("MessageKeyEventManager").GetComponent<MessageKeyEventSec12>();
                messages = textLoader.LoadTextAsDic(TextPath.Sec12());
                break;
        }
    }

    //*******************************************************************
    //                メッセージパネルがタッチされた時の処理
    //*******************************************************************
    public void OnClick()
    {
        if (gameManager.IsStartScenario.Value && !isChoice)
        {
            //前のメッセージを書いている途中かどうかで分ける
            if (isWriting)
            {
                //書いている途中にタッチされた時------------------------------
                //スピード(かかる時間)を 0 にして、すぐに最後まで書く
                writeSpeed = 0.0f;
            }
            else
            {
                keyEvent.EffectEvent(messageKey.Key, () =>messageKey.Next(), () => WriteText());
                if (!gameManager.IsEffect)
                {
                    if (messages.Count > messageKey.Key)
                    {
                        //書き終わったあとでタッチされた時----------------------------
                        WriteText();
                        messageKey.Next();
                    }
                    else
                    {
                        //すべてのテキストを読み終えた時------------------------------
                        if (gameManager.CurrentState.Value == GameState.Sec7)
                        {
                            choice = GameObject.FindWithTag("Modal").GetComponent<Choice>();
                            isChoice = true;
                            choice.Show();
                        }
                        else if (gameManager.CurrentState.Value == GameState.Sec10)
                        {
                            choice = GameObject.FindWithTag("Modal").GetComponent<Choice>();
                            isChoice = true;
                            choice.Show();
                        }
                        else
                        {
                            Clean();
                            gameManager.ScenarioToExplore(gameManager.CurrentState.Value);
                        }
                    }
                }
            }
        }
    }

    private void WriteText()
    {
        Clean();
        Write(messages[messageKey.Key]);
        keyEvent.Event(messageKey.Key);
    }

    public void Choice(int num, GameState current)
    {
        if (current == GameState.Sec7)
        {
            if (num == 0)
            {
                gameManager.CurrentState.Value = GameState.Sec8;
                isChoice = false;
                choice.Hide();
                WriteText();
                messageKey.Next();
            }
            else
            {
                gameManager.CurrentState.Value = GameState.Sec9;
                isChoice = false;
                choice.Hide();
                WriteText();
                messageKey.Next();
            }
        }
        else if (current == GameState.Sec10)
        {
            if (num == 0)
            {
                gameManager.CurrentState.Value = GameState.Sec12;
                isChoice = false;
                choice.Hide();
                WriteText();
                messageKey.Next();
            }
            else
            {
                gameManager.CurrentState.Value = GameState.Sec11;
                isChoice = false;
                choice.Hide();
                WriteText();
                messageKey.Next();
            }
        }
    }
}
