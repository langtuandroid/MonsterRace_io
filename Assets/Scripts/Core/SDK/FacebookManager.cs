using Facebook.Unity;
using UnityEngine;

namespace Core.SDK
{
    public class FacebookManager : MonoBehaviour
    {
        private void Awake()
        {
            if (!FB.IsInitialized)
            {
                FB.Init(InitCallback, OnHideUnity);
                Debug.Log("init compleate");
            }
            else
            {
                FB.ActivateApp();
            }
        }

        private void InitCallback()
        {
            if (FB.IsInitialized)
            {
                FB.ActivateApp();
            }
            else
            {
                Debug.Log("Failed to Initialize the Facebook SDK");
            }
        }

        private void OnHideUnity(bool isGameShown)
        {
            Time.timeScale = !isGameShown ? 0 : 1;
        }
    }
}
