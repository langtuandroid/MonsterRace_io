using System.Collections;
using UnityEngine;
using DG.Tweening;

namespace Cor
{
    public class LobbyCharacter : MonoBehaviour
    {
        [System.Serializable]
        public class Placements
        {
            public GameObject[] fieldsParts;
        }

        #region Variables

        [SerializeField] GameObject[] skeleton;
        [SerializeField] Placements[] placement;
        [SerializeField] GameObject[] groups;
        [SerializeField] GameObject placementFX;
        [SerializeField] GameObject loadingPlacement;
        [SerializeField] Animator _animCharacter;
        [SerializeField] Animator platformAnim;
        [SerializeField] Transform point;
        [SerializeField] Transform scrollPoint;
        [SerializeField] PlayerCharacterSkin _playerCharacterSkin;
        [SerializeField] ParticleSystem effectOpenPart;
        [SerializeField] SceneLoader _sceneLoader;
        [SerializeField] GameObject buttonLeft;
        [SerializeField] GameObject buttonRight;
        [SerializeField] private int indexProgress;
        [SerializeField] private float scroll;

        private Tutorial _tutorial;

        #endregion

        private void Start()
        {
            Application.targetFrameRate = 60;
            foreach(var i in placement[indexProgress].fieldsParts)
            {
                i.SetActive(true);
            }
            _tutorial = GameObject.FindObjectOfType<Tutorial>();
        }

        public void NewPartOpen(CharacterMonsterType partType)
        {
            effectOpenPart.Play();
            _animCharacter.SetTrigger("Reaction");
            _tutorial.Complet();
            if (indexProgress == 0)
            {
                _playerCharacterSkin.AddHeadPart(partType);
                skeleton[indexProgress].SetActive(false);
            }
            if (indexProgress == 1)
            {
                _playerCharacterSkin.AddBodyPart(partType);
                skeleton[1].SetActive(false);
            }
            if (indexProgress == 2)
            {
                _playerCharacterSkin.AddArmsPart(partType);
                skeleton[2].SetActive(false);
            }
            if (indexProgress == 3)
            {
                _playerCharacterSkin.AddLegsPart(partType);
                skeleton[3].SetActive(false);
            }
            foreach (var i in placement[indexProgress].fieldsParts)
            {
                i.SetActive(false);
            }

            indexProgress++;
            VibrationManager.Instance.HeavyVibration();

            if (indexProgress >= 4)
            {
                transform.parent = point;
                placementFX.SetActive(false);
                loadingPlacement.SetActive(true);
                buttonLeft.SetActive(false);
                buttonRight.SetActive(false);
                StartCoroutine(IE_PlatformActive());
                StartCoroutine(IE_ExitLobby());
                return;
            }
            foreach (var i in placement[indexProgress].fieldsParts)
            {
                i.SetActive(true);
            }
        }

        public void NextGroup()
        {
            scroll -= 8.8f;
            buttonLeft.SetActive(true);
            if (scroll <= -26.4f)
            {
                buttonRight.SetActive(false);
                scroll = -26.4f;
            }
            scrollPoint.DOLocalMoveX(scroll, 0.5f);
        }

        public void BackGroup()
        {
            scroll += 8.8f;
            buttonRight.SetActive(true);
            if(scroll >= 0)
            {
                buttonLeft.SetActive(false);
                scroll = 0;
            }
            scrollPoint.DOLocalMoveX(scroll, 0.5f);
        }

        private IEnumerator IE_PlatformActive()
        {
            yield return new WaitForSeconds(1.2f);

            platformAnim.enabled = true;
        }

        private IEnumerator IE_ExitLobby()
        {
            yield return new WaitForSeconds(2.1f);

            _sceneLoader.Loaded(1);
        }
    }
}