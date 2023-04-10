using System.Collections;
using UnityEngine;

namespace Cor
{
    public class LobbyCharacter : MonoBehaviour
    {
        [SerializeField] GameObject[] skeleton;
        [SerializeField] GameObject[] placement;
        [SerializeField] GameObject placementFX;
        [SerializeField] GameObject loadingPlacement;
        [SerializeField] Animator _animCharacter;
        [SerializeField] Animator platformAnim;
        [SerializeField] Transform point;
        [SerializeField] PlayerCharacterSkin _playerCharacterSkin;
        [SerializeField] ParticleSystem effectOpenPart;
        [SerializeField] SceneLoader _sceneLoader;
        [SerializeField] private int indexProgress;

        Tutorial _tutorial;

        private void Start()
        {
            placement[indexProgress].SetActive(true);
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
                skeleton[0].SetActive(false);
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
            indexProgress++;
            VibrationManager.Instance.PartOpenVibration();
            foreach (var i in placement)
            {
                i.SetActive(false);
            }
            
            if (indexProgress >= 4)
            {
                transform.parent = point;
                placementFX.SetActive(false);
                loadingPlacement.SetActive(true);
                StartCoroutine(IE_PlatformActive());
                StartCoroutine(IE_ExitLobby());
                return;
            }
            placement[indexProgress].SetActive(true);
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
