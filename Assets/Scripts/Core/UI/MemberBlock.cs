using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace Core
{
    public class MemberBlock : MonoBehaviour
    {
        #region Variables

        [SerializeField] private GameObject crown;
        [SerializeField] private Text textBlock;
        [SerializeField] private Slider sliderBlock;
        [SerializeField] private Image imgBlock;
        [SerializeField] private Color norm;
        [SerializeField] private Color fade;
        [SerializeField] private Image bgBlock;
        [SerializeField] private Color colorStandart;
        [SerializeField] private Color colorBlock;
        [SerializeField] private DOTweenAnimation blockPunch;
        [SerializeField] private float scaleNormal;
        [SerializeField] private float scaleMinimal;

        #endregion

        public void SetColorBlock(Color color)
        {
            colorBlock = color;
            imgBlock.color = colorBlock;
            textBlock.color = Color.white;
            sliderBlock.value = 0;
            sliderBlock.minValue = 0;
            sliderBlock.maxValue = 100;
            transform.localScale = new Vector3(scaleNormal, scaleNormal, scaleNormal);
        }

        public void SetProgressBlock(string text, int progressValue)
        {
            textBlock.text = text;
            sliderBlock.value = progressValue;
        }

        public void BlockAnimation()
        {
            blockPunch.DORestart();
        }

        public void LeaderBlock(bool isLeader)
        {
            if (isLeader)
            {
                crown.SetActive(true);
                imgBlock.color = colorBlock;
                bgBlock.color = norm;
                textBlock.color = Color.white;
                transform.localScale = new Vector3(scaleNormal, scaleNormal, scaleNormal);
                return;
            }

            crown.SetActive(false);
            imgBlock.color = colorStandart;
            bgBlock.color = fade;
            textBlock.color = colorBlock;
            transform.localScale = new Vector3(scaleMinimal, scaleMinimal, scaleMinimal);
        }
    }
}
