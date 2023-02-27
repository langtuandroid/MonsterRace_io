using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlueStellar.Cor
{
    public class Fog : MonoBehaviour
    {
        [SerializeField] Color _colorFog;
        [SerializeField] private bool _fogOn;

        private void Start()
        {
            RenderSettings.fogColor = _colorFog;
            RenderSettings.fog = _fogOn;
        }
    }
}
