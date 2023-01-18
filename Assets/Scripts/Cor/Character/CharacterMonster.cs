using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public enum CharacterMonsterType
{
    HuggyWuggy,
    Baldy,
    MotherSpider,
    CartoonCat,
    Siren,
    Venom
}

namespace PlayKing.Cor
{
    public class CharacterMonster : MonoBehaviour
    {
        [System.Serializable]
        public class Monster
        {
            public CharacterMonsterType monsterType;
            public List<GameObject> monsterBody;
            public GameObject monsterWeapon;
            public RuntimeAnimatorController monsterAnimator;
        }

        [SerializeField] List<Monster> monsters = new List<Monster>();
        [SerializeField] List<GameObject> monsterHeads = new List<GameObject>();
        [SerializeField] List<MonsterBall> currencyBalls = new List<MonsterBall>();
        [SerializeField] CharacterStates _characterStates;
        [SerializeField] CharacterSkins _characterSkins;
        [SerializeField] Animator _anim;
        [SerializeField] GameObject attackField;
        [SerializeField] Transform p;
        public void SetMonster(CharacterMonsterType _monsterType)
        {
            foreach(var i in monsters)
            {
                if(i.monsterType == _monsterType)
                {
                    foreach(var d in i.monsterBody) { d.SetActive(true); }
                    i.monsterWeapon.SetActive(true);
                    _anim.runtimeAnimatorController = i.monsterAnimator;
                    break;
                }
            }

            SwitchHead(_characterSkins.Type());
        }

        public void AddMonsterBall(MonsterBall monsterBall)
        {
            currencyBalls.Add(monsterBall);
        }

        public void ExplosionCharacterMonster(Transform target)
        {
            foreach (var i in currencyBalls)
            {
                Vector3 dirImpulse = target.position - i.transform.position;
                i.Explosion(dirImpulse);
                i.transform.parent = null;
            }

            _characterStates.CharacterDie();
            _characterStates.Die();
        }

        Skin _skin;

        public void ToPoint(Skin skin)
        {
            
        }

        private void Unstack()
        {
            for (int i = currencyBalls.Count - 1; i >= 0; i--)
            {
                if (currencyBalls[i].isHead)
                {
                    currencyBalls[i].transform.DOScale(0, 0.2f);
                }
                currencyBalls[i].transform.SetParent(null);
                currencyBalls[i].transform.DOMove(transform.position + Vector3.up * 4f, 0.15f);
                currencyBalls[i].transform.DOJump(p.transform.position, 2, 1, 0.3f).SetDelay(0.15f);
                Destroy(currencyBalls[i].gameObject, 0.5f);
                currencyBalls.Remove(currencyBalls[i]);
                _skin.UpdateSkin(true);
                return;
            }
        }

        private void SwitchHead(CharacterMonsterType characterMonster)
        {
            switch (characterMonster)
            {
                case CharacterMonsterType.HuggyWuggy:
                    monsterHeads[0].SetActive(true);
                    break;
                case CharacterMonsterType.MotherSpider:
                    monsterHeads[1].SetActive(true);
                    break;
                case CharacterMonsterType.Baldy:
                    monsterHeads[2].SetActive(true);
                    break;
                case CharacterMonsterType.CartoonCat:
                    monsterHeads[3].SetActive(true);
                    break;
                case CharacterMonsterType.Siren:
                    monsterHeads[4].SetActive(true);
                    break;
                case CharacterMonsterType.Venom:
                    monsterHeads[5].SetActive(true);
                    break;
            }
        }

        public void AttackFieldActive(bool isActive)
        {
            if (isActive) { attackField.transform.DOScale(attackField.transform.localScale, 0.5f).From(0); }
            if (!isActive) { attackField.transform.DOScale(0, 0.5f); }
        }

        private bool can;

        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.CompareTag("Finish"))
            {
                if (!can)
                {
                    Skin skin = other.GetComponent<Skin>();
                    _skin = skin;
                    PlayerMovement playerMovement = GetComponentInParent<PlayerMovement>();
                    playerMovement.transform.DORotate(new Vector3(0, -90f, 0f), 0.5f);
                    CameraController.Instance.FinishCam();
                    StartCoroutine(IE_Can());
                }

                if (can)
                {
                    Unstack();
                }
            }
        }

        private IEnumerator IE_Can()
        {
            yield return new WaitForSeconds(0.7f);

            can = true;
        }
    }
}
