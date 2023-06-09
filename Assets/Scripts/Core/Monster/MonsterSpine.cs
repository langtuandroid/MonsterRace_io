using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace Core
{
    public class MonsterSpine : MonoBehaviour
    {
        #region Variables

        [SerializeField] private List<MonsterBall> currencyBalls = new List<MonsterBall>();
        private bool _canUnstack;

        private Skin _skin;   

        #endregion
     

        public void AddBallsToSpine(MonsterBall monsterBall)
        {
            currencyBalls.Add(monsterBall);
        }

        public void CrushSpine(Transform target) 
        {
            foreach (var i in currencyBalls)
            {
                i.transform.parent = null;
                Vector3 dirImpulse = target.position - i.transform.position;
                i.Explosion(dirImpulse);
            }
        }

        private void Unstack()
        {
            Vector3 unstackPoint = _skin.transform.position;

            for (var i = currencyBalls.Count - 1; i >= 0; i--)
            {
                if (currencyBalls[i].IsHeadBall())
                    currencyBalls[i].transform.DOScale(0, 0.2f);

                currencyBalls[i].transform.SetParent(null);
                currencyBalls[i].transform.DOMove(transform.position + Vector3.up * 4f, 0.15f);
                currencyBalls[i].transform.DOJump(unstackPoint, 2, 1, 0.3f).SetDelay(0.15f);
                Destroy(currencyBalls[i].gameObject, 0.5f);
                currencyBalls.Remove(currencyBalls[i]);
                _skin.UpdateSkin();
                return;
            }

            if (currencyBalls.Count != 0 || isk) 
                return;
           
            _skin.OpenFramgentSkin();
            isk = true;
        }

        private bool isk;
        private bool isw;

        private IEnumerator IE_CanUnstack()
        {
            yield return new WaitForSeconds(0.7f);

            _canUnstack = true;
        }

        private void OnTriggerStay(Collider other)
        {
            if (!other.gameObject.CompareTag("Finish")) 
                return;
            
            Skin skin = other.GetComponentInParent<Skin>();
            _skin = skin;

            if (!isw)
            {
                CharacterStates characterStates = GetComponentInParent<CharacterStates>();
                characterStates.RootToFinish();
                CameraController.Instance.JumpStateCam(false);
                CameraController.Instance.SkinCam(_skin.transform, true);
                isw = true;
            }

            if (_canUnstack)
            {
                Unstack();
                return;
            }

            StartCoroutine(IE_CanUnstack());
        }
    }
}
