﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AlchemyPlanet.StoryLobbyScene
{
    public class ButtonStart : MonoBehaviour
    {
        private Button button;

        private void Awake()
        {
            button = GetComponent<Button>();
            button.onClick.AddListener(OnClickButtonStart);
        }

        private void OnClickButtonStart()
        {
            if(StoryManager.Instance.CurrentChaper == 1)
            {
                if (StoryManager.Instance.CurrentStage == 1)
                    Debug.Log("ALERT!");
                else if (StoryManager.Instance.CurrentStage == 7)
                    Debug.Log("ALERT!");
                else
                    SceneChangeManager.Instance.ChangeSceneWithLoading("GameScene");
            }
        }
    }
}