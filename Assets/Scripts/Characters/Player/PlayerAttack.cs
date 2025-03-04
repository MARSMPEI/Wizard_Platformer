using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game.Character.Player {
    public class PlayerAttack :CharacterAttack {
        [SerializeField] PlayerContoller playerContoller;

        public override void Init(ControllerOfCharacter character) {
            base.Init(character);
            playerContoller = GetComponent<PlayerContoller>();
            playerContoller.playerState.ChangeCountOfArrow(countOfArrow);
        }

        public override GameObject Weapon {
            get{
                if (playerContoller.characterBody.weaponSlot.childCount <= 0) return null;
                return playerContoller.characterBody.weaponSlot.GetChild(0).gameObject;
            } 
        }

        public override void Attack(bool inputAttack) {
            base.Attack(inputAttack);
           // playerContoller.playerAnimation.IsAttacking = inputAttackContinuous;
        }

        public override void Shoot() {
            base.Shoot();
            playerContoller.playerState.ChangeCountOfArrow(countOfArrow);
        }

        protected override void SetIsDrawingBow(bool value) =>
            playerContoller.playerAnimation.SetIsDrawingBow = value;
        protected override void SetIsArrowDrawn(bool value) =>
            playerContoller.playerAnimation.SetIsArrowDrawn = value;
        protected override void SetIsAttacking(bool value) =>
            playerContoller.playerAnimation.SetIsAttacking = value;
        protected override void SetAttackAction(int value) =>
            playerContoller.playerAnimation.SetAttackAction = value;
    }
}