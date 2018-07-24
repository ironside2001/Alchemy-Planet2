﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace AlchemyPlanet.GameScene
{
    public class Item : Bubble, IPointerUpHandler
    {
        public enum ItemName { IncreasePurify, NoReducedOxygen, RainbowColorBall, SlowReducedOxygen, Sprint }

        public ItemName itemName;

        public void OnPointerUp(PointerEventData eventData)
        {
            switch(itemName)
            {
                case ItemName.IncreasePurify: ItemManager.Instance.IncreasePurify(); break;
                case ItemName.NoReducedOxygen: ItemManager.Instance.NoReducedOxygen(); break;
                case ItemName.RainbowColorBall: ItemManager.Instance.RainbowColorBall(); break;
                case ItemName.SlowReducedOxygen: ItemManager.Instance.SlowReducedOxygen(); break;
                case ItemName.Sprint: ItemManager.Instance.Sprint(); break;
            }

            ItemManager.Instance.Objects.Remove(gameObject);
            Destroy(gameObject);
        }
    }
}