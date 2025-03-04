using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace Game.UI.InGame {
    public class PlayerInfo :CharacterInfo {

        public TextMeshProUGUI arrowCount;
        public override void Init(bool startOpened = false) {
            base.Init(startOpened);
        }

        public void SetArrowCount(int value) => arrowCount.text = value.ToString();
    }
}