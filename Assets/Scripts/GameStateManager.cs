
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager instance;

    public Action<GameStates> StateChange;

    public Action<GameLevels> LevelChange;

    public GameLevels currentLevel;
    public GameStates currentState;

    private void Awake()
    {
        instance = this;
    }

    public void OnGameStateChange(GameStates gameStates)
    {
        currentState = gameStates;
        StateChange?.Invoke(currentState);
    }

    public void OnGameLevelChange(GameLevels gameLevels)
    {
        currentLevel = gameLevels;
        LevelChange?.Invoke(currentLevel);
    }

}

public enum GameStates
{
    Menu,
    Play,
    Pause,
    GameOver,
}

public enum GameLevels
{
    Easy,
    Medium,
    Hard,
}


//////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class LevelPage : BaseClass
{
    [SerializeField] Button easyModeBtn;
    [SerializeField] Button mediumModeBtn;
    [SerializeField] Button hardModeBtn;

    [HideInInspector] public float spawnSpeed;

    private void Start()
    {
        easyModeBtn.onClick.AddListener(OnBtn_EasyMode);
        mediumModeBtn.onClick.AddListener(OnBtn_MediumMode);
        hardModeBtn.onClick.AddListener(OnBtn_HardMode);
    }

    public void OnBtn_EasyMode()
    {
        EventManager.LoadGame();
        ScoreManager.instance.timeValue = 60;
        spawnSpeed = 1;
        ScoreManager.instance.timeDetails = ScoreManager.instance.timeValue;
        UIManager.iManager.ShowNextScreen(CanvasStates.GameScreen);
        GameStateManager.instance.OnGameStateChange(GameStates.Play);
    }

    public void OnBtn_MediumMode()
    {
        EventManager.LoadGame();
        ScoreManager.instance.timeValue = 30;
        spawnSpeed = 0.6f;
        ScoreManager.instance.timeDetails = ScoreManager.instance.timeValue;
        UIManager.iManager.ShowNextScreen(CanvasStates.GameScreen);
        GameStateManager.instance.OnGameStateChange(GameStates.Play);

    }

    public void OnBtn_HardMode()
    {
        EventManager.LoadGame();
        ScoreManager.instance.timeValue = 15;
        spawnSpeed = 0.3f;
        ScoreManager.instance.timeDetails = ScoreManager.instance.timeValue;
        Debug.Log("Time Value : " + ScoreManager.instance.timeValue);
        UIManager.iManager.ShowNextScreen(CanvasStates.GameScreen);
        GameStateManager.instance.OnGameStateChange(GameStates.Play);
    }
}