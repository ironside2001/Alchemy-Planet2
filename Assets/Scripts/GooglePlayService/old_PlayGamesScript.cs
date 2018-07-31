﻿using System.Collections;
using System.Collections.Generic;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine;

public class old_PlayGamesScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
        // enables saving game progress.
        PlayGamesPlatform.InitializeInstance(config);
        // recommended for debugging:
        PlayGamesPlatform.Activate();

        SignIn();
    }

    void SignIn()
    {
        Social.localUser.Authenticate((bool succcess) => {
            if (succcess)
            {
                ShowAchievementsUI();
            }
            else
            {
                Debug.Log("Failed!");
            }
        });
    }

    #region Achievements
    public static void UnloadAchievement(string Id)
    {
        Social.ReportProgress(Id, 100, success => { });
    }

    public static void IncerementAchievement(string id, int stepsToIncerement)
    {
        PlayGamesPlatform.Instance.IncrementAchievement(id, stepsToIncerement, success => { });
    }

    public static void ShowAchievementsUI()
    {
        Social.ShowAchievementsUI();
    }
    #endregion /

    #region Leaderboards
    public static void AddScoreToLeaderboard(string leaderboardId, long score)
    {
        Social.ReportScore(score, leaderboardId, success => { });
    }

    public static void ShowLeaderboardsUI()
    {
        Social.ShowLeaderboardUI();
    }
    #endregion /
}