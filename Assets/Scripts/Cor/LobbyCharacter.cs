using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BlueStellar.Cor
{
    public class LobbyCharacter : MonoBehaviour
    {
        [SerializeField] GameObject[] skeleton;
        [SerializeField] GameObject[] placement;
        [SerializeField] Animator _animCharacter;
        [SerializeField] Animator platformAnim;
        [SerializeField] Transform point;
        [SerializeField] PlayerCharacterSkin _playerCharacterSkin;
        [SerializeField] ParticleSystem effectOpenPart;
        [SerializeField] private int indexProgress;

        Tutorial _tutorial;
       // LoadGame _loadGame;

        private void Start()
        {
            placement[indexProgress].SetActive(true);
            _tutorial = GameObject.FindObjectOfType<Tutorial>();
         //   _loadGame = GameObject.FindObjectOfType<LoadGame>();
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
            VibrationController.Instance.PartOpenVibration();
            foreach (var i in placement)
            {
                i.SetActive(false);
            }
            
            if (indexProgress >= 4)
            {
                transform.parent = point;
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
            yield return new WaitForSeconds(3.2f);

            SceneManager.LoadScene(1);
        }
    }
}
