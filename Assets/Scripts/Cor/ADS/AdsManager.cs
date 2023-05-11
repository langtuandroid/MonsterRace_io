using System;
using UnityEngine;

namespace Cor
{
    public class AdsManager : MonoBehaviour
    {
        #region Singelton

        public static AdsManager Instance;

        private void Awake()
        {
            Instance = this;
        }

        #endregion

        #region Variables

        private string bannerAdUnitId = "d35db003fcd7f1b3";
        private bool isDeactiveBanner;

        private string interAdID = "e486dda9cf9b0372";
        private int retryAttempt;

        private string rewardAdId = "aba15d180775d493";
        private int retryAttemptReward;

        public static bool IsReadyInter;
        public static bool IsReadyReward;

        private string _placement;

        private RewardAdsType _rewardAdsType;

        private SkinPart _skinPart;
        private MultiplyMoneyButton _moneyButton;
        private BonusButton _bonusButton;
        private ExtraMoneyButton _extraMoneyButton;
        private Shop _shop;

        #endregion

        #region Actions

        public Action StopedTimer;

        #endregion

        private bool CheckInternetConnection()
        {
            if (Application.internetReachability != NetworkReachability.NotReachable)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Start()
        {
            CheckBannerStatus();
            InitzalizationIntersyichalAd();
            InitzalizationRewardAd();

            MaxSdk.SetSdkKey("6AQkyPv9b4u7yTtMH9PT40gXg00uJOTsmBOf7hDxa_-FnNZvt_qTLnJAiKeb5-2_T8GsI_dGQKKKrtwZTlCzAR");
            MaxSdk.InitializeSdk();
        }

        #region BannerActions

        private void CheckBannerStatus() 
        {
            MaxSdkCallbacks.Banner.OnAdLoadedEvent += OnBannerAdLoadedEvent;
            MaxSdkCallbacks.Banner.OnAdLoadFailedEvent += OnBannerAdFailedEvent;
            MaxSdkCallbacks.Banner.OnAdClickedEvent += OnBannerAdClickedEvent;
            MaxSdkCallbacks.Banner.OnAdRevenuePaidEvent += OnBannerAdRevenuePaidEvent;

            if (!isDeactiveBanner)
            {
                MaxSdkCallbacks.OnSdkInitializedEvent += (MaxSdkBase.SdkConfiguration sdkConfiguration) =>
                {
                    MaxSdk.CreateBanner(bannerAdUnitId, MaxSdkBase.BannerPosition.BottomCenter);

                    MaxSdk.SetBannerBackgroundColor(bannerAdUnitId, Color.white);
                    MaxSdk.ShowBanner(bannerAdUnitId);
                    MaxSdk.SetBannerExtraParameter(bannerAdUnitId, "ad_refresh_seconds", "30");
                };
            }
        }

        private void OnBannerAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
        {
         
        }

        private void OnBannerAdFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
        {
         
        }

        private void OnBannerAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
        {
        
        }

        private void OnBannerAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
        {
            double revenue = adInfo.Revenue;

            string countryCode = MaxSdk.GetSdkConfiguration().CountryCode; // "US" for the United States, etc - Note: Do not confuse this with currency code which is "USD" in most cases!
            string networkName = adInfo.NetworkName; // Display name of the network that showed the ad (e.g. "AdColony")
            string adUnitIdentifier = adInfo.AdUnitIdentifier; // The MAX Ad Unit ID
            string placement = adInfo.Placement; // The placement this ad's postbacks are tied to
        }

        #endregion

        #region InterstitionalActions

        public void ShowInter(string placement)
        {
            if (!IsReadyInter)
            {
                if (!IsReadyReward)
                {
                    AdsAvailableEvent("interstitial", "not_available");
                    return;
                }
                return;
            }

            MaxSdk.ShowInterstitial(interAdID);
            _placement = placement;
            AdsAvailableEvent("interstitial", "success");
            AdsStartedEvent("interstitial", "success");
            LevelManager.Instance.LevelPause();
        }

        private void LoadInterstitial()
        {
            MaxSdk.LoadInterstitial(interAdID);
        }

        private void InitzalizationIntersyichalAd()
        {
            MaxSdkCallbacks.Interstitial.OnAdLoadedEvent += OnInterstitialLoadedEvent;
            MaxSdkCallbacks.Interstitial.OnAdLoadFailedEvent += OnInterstitialLoadFailedEvent;
            MaxSdkCallbacks.Interstitial.OnAdDisplayedEvent += OnInterstitialDisplayedEvent;
            MaxSdkCallbacks.Interstitial.OnAdClickedEvent += OnInterstitialClickedEvent;
            MaxSdkCallbacks.Interstitial.OnAdHiddenEvent += OnInterstitialHiddenEvent;
            MaxSdkCallbacks.Interstitial.OnAdDisplayFailedEvent += OnInterstitialAdFailedToDisplayEvent;

            LoadInterstitial();
        }

        private void OnInterstitialLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
        {
            IsReadyInter = true;
            retryAttempt = 0;
        }

        private void OnInterstitialLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
        {
            retryAttempt++;
            double retryDelay = Math.Pow(2, Math.Min(6, retryAttempt));

            Invoke("LoadInterstitial", (float)retryDelay);
        }

        private void OnInterstitialDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo) 
        {
            AdsWatchEvent("interstitial", "watched");
        }

        private void OnInterstitialAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
        {
            LoadInterstitial();
        }

        private void OnInterstitialClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo) 
        {
            LoadInterstitial();
            AdsWatchEvent("interstitial", "clicked");
        }

        private void OnInterstitialHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
        {
            LoadInterstitial();
            LevelManager.Instance.LevelContinue();
        }

        #endregion

        #region RewardActions

        #region SetRewardType

        public void PartReward(SkinPart skinPart)
        {
            if (!IsReadyReward)
            {
                AdsAvailableEvent("rewarded", "not_available");
                return;
            }
            _skinPart = skinPart;
            _rewardAdsType = RewardAdsType.PartSkin;
            _placement = "part_open";
            ShowReward();
        }

        public void MultyplyMoneyReward(MultiplyMoneyButton moneyButton)
        {
            if (!IsReadyReward)
            {
                AdsAvailableEvent("rewarded", "not_available");
                return;
            }
            _moneyButton = moneyButton;
            _rewardAdsType = RewardAdsType.MultiplyMoney;
            _placement = "lose_getX2";
            ShowReward();
        }

        public void BonusMoneyReward(BonusButton bonusButton)
        {
            if (!IsReadyReward)
            {
                AdsAvailableEvent("rewarded", "not_available");
                return;
            }
            _bonusButton = bonusButton;
            _rewardAdsType = RewardAdsType.BonusMoney;
            _placement = "win_bonus_money";
            ShowReward();
        }

        public void ExtraMoneyReward(ExtraMoneyButton extraButton)
        {
            if (!IsReadyReward)
            {
                AdsAvailableEvent("rewarded", "not_available");
                return;
            }
            _extraMoneyButton = extraButton;
            _rewardAdsType = RewardAdsType.ExtraMoney;
            _placement = "shop_bonus_money";
            ShowReward();
        }

        public void ShopReward(Shop shop)
        {
            if (!IsReadyReward)
            {
                AdsAvailableEvent("rewarded", "not_available");
                return;
            }
            _shop = shop;
            _rewardAdsType = RewardAdsType.Shop;
            _placement = "shop_product";
            ShowReward();
        }

        public void SkipReward()
        {
            if(!IsReadyReward)
            {
                AdsAvailableEvent("rewarded", "not_available");
                return;
            }
            _rewardAdsType = RewardAdsType.SkipLevel;
            _placement = "skip_level";
            ShowReward();
        }

        #endregion

        private void InitzalizationRewardAd()
        {
            MaxSdkCallbacks.Rewarded.OnAdLoadedEvent += OnRewardedAdLoadedEvent;
            MaxSdkCallbacks.Rewarded.OnAdLoadFailedEvent += OnRewardedAdLoadFailedEvent;
            MaxSdkCallbacks.Rewarded.OnAdDisplayedEvent += OnRewardedAdDisplayedEvent;
            MaxSdkCallbacks.Rewarded.OnAdClickedEvent += OnRewardedAdClickedEvent;
            MaxSdkCallbacks.Rewarded.OnAdRevenuePaidEvent += OnRewardedAdRevenuePaidEvent;
            MaxSdkCallbacks.Rewarded.OnAdHiddenEvent += OnRewardedAdHiddenEvent;
            MaxSdkCallbacks.Rewarded.OnAdDisplayFailedEvent += OnRewardedAdFailedToDisplayEvent;
            MaxSdkCallbacks.Rewarded.OnAdReceivedRewardEvent += OnRewardedAdReceivedRewardEvent;

            LoadRewardedAd();
        }

        private void LoadRewardedAd()
        {
            MaxSdk.LoadRewardedAd(rewardAdId);
        }

        private void OnRewardedAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
        {
            IsReadyReward = true;
            retryAttemptReward = 0;
        }

        private void OnRewardedAdLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
        {
            retryAttemptReward++;
            double retryDelay = Math.Pow(2, Math.Min(6, retryAttemptReward));

            Invoke("LoadRewardedAd", (float)retryDelay);
        }

        private void OnRewardedAdDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo) 
        {
            AdsWatchEvent("rewarded", "watched");
        }

        private void OnRewardedAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
        {
            LoadRewardedAd();
        }

        private void OnRewardedAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo) 
        {
            LoadRewardedAd();
            AdsWatchEvent("rewarded", "clicked");
        }

        private void OnRewardedAdHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
        {
            LoadRewardedAd();
        }

        private void OnRewardedAdReceivedRewardEvent(string adUnitId, MaxSdk.Reward reward, MaxSdkBase.AdInfo adInfo)
        {
            ClaimReward();
            Debug.Log("ClaimReward");
        }

        private void OnRewardedAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
        {

        }

        private void ShowReward()
        {
            MaxSdk.ShowRewardedAd(rewardAdId);
            AdsAvailableEvent("rewarded", "success");
            AdsStartedEvent("rewarded", "success");
        }

        private void ClaimReward()
        {
            switch (_rewardAdsType)
            {
                case RewardAdsType.PartSkin:
                    if (_skinPart != null)
                        _skinPart.AddCount();
                    break;
                case RewardAdsType.MultiplyMoney:
                    if (_moneyButton != null) 
                        _moneyButton.ClaimMoney();
                    break;
                case RewardAdsType.BonusMoney:
                    if (_bonusButton != null)
                        _bonusButton.ClaimBonus();
                    break;
                case RewardAdsType.ExtraMoney:
                    if (_extraMoneyButton != null)
                        _extraMoneyButton.ClaimBonus();
                    break;
                case RewardAdsType.Shop:
                    if (_shop != null)
                        _shop.ClaimAdsBonus();
                    break;
                case RewardAdsType.SkipLevel:
                    LevelManager.Instance.SkipLevel();
                    break;
            }

            StopedTimer?.Invoke();
            _rewardAdsType = RewardAdsType.Null;
            LoadRewardedAd();
        }

        #endregion

        #region AnalyticsEvents

        public void AdsAvailableEvent(string _adType, string _result)
        {
            var eventVariables = "{\"ad_type\":\"" + _adType + "\"," +
                               "\"placement\":\"" + _placement + "\"," +
                               "\"result\":\"" + _result + "\"," +
                               "\"conection\":\"" + CheckInternetConnection() + "\"," +
                               "}";

            AppMetrica.Instance.ReportEvent("video_ads_available", eventVariables);
            AppMetrica.Instance.SendEventsBuffer();
        }

        public void AdsStartedEvent(string _adType, string _result)
        {
            var eventVariables = "{\"ad_type\":\"" + _adType + "\"," +
                               "\"placement\":\"" + _placement + "\"," +
                               "\"result\":\"" + _result + "\"," +
                               "\"conection\":\"" + CheckInternetConnection() + "\"," +
                               "}";

            AppMetrica.Instance.ReportEvent("video_ads_started", eventVariables);
            AppMetrica.Instance.SendEventsBuffer();
        }

        public void AdsWatchEvent(string _adType, string _result)
        {
            var eventVariables = "{\"ad_type\":\"" + _adType + "\"," +
                               "\"placement\":\"" + _placement + "\"," +
                               "\"result\":\"" + _result + "\"," +
                               "\"conection\":\"" + CheckInternetConnection() + "\"," +
                               "}";

            AppMetrica.Instance.ReportEvent("video_ads_watch", eventVariables);
            AppMetrica.Instance.SendEventsBuffer();
        }

        #endregion
    }
}