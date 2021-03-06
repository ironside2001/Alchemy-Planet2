﻿using UnityEngine;

namespace AlchemyPlanet.GameScene
{
    public class PrefabManager : MonoBehaviour
    {
        public static PrefabManager Instance { get; private set; }

        public GameObject[] itemPrefabs;
        public GameObject[] recipePrefabs;
        public GameObject[] dropMaterialPrefabs;
        public GameObject monster;
        public GameObject bossMonster;
        public GameObject popinBullet;
        public GameObject harpRadishealBullet;
        public GameObject line;
        public GameObject coin;
        public GameObject scoreText;

        public GameObject potionEffectRed;
        public GameObject potionEffectGreen;
        public GameObject potionEffectBlue;
        public GameObject potionEffectRainbow;
        public GameObject potionEffectBomb;

        public Sprite unselectedBubble;
        public Sprite selectedBubble;
        public Sprite highlightedBubble;

        private void OnDestroy()
        {
            Instance = null;
        }

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);
        }
    }
}