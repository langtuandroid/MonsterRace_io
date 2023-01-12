using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

namespace PlayKing.Cor
{
    public class MemberBlock : MonoBehaviour
    {
        [SerializeField] Image bgImgBlock;
        [SerializeField] TextMeshProUGUI textBlock;
        [SerializeField] DOTweenAnimation blockPunch;

        public void SetColorBlock(Color _color)
        {
            bgImgBlock.color = _color;
        }

        public void SetTextBlock(string _text)
        {
            textBlock.text = _text;
        }

        public void BlockAnimation()
        {
            blockPunch.DORestart();
        }
    }
}
