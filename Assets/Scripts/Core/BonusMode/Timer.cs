using System;
using UnityEngine;
using UnityEngine.UI;

namespace Core
{
    public class Timer : MonoBehaviour
    {
        #region Variables

        [SerializeField] private Text _text;
        private DateTime _startTime;
        private TimeSpan _currentTime;
        private TimeSpan _oneDay = new TimeSpan(24, 0, 0);
        
        #endregion

        private void Start()
        {
            StartTime();
        }

        private void Update()
        {
            _currentTime = DateTime.UtcNow - _startTime;
            if (_currentTime >= _oneDay)
            {
                StartTime();
            }
            _text.text = GetTime(_currentTime);
        }

        private void StartTime()
        {
            _startTime = DateTime.UtcNow;
        }

        private string GetTime(TimeSpan time)
        {
            TimeSpan countdown = _oneDay - time;
            return countdown.Hours.ToString() + "h" + ":" + countdown.Minutes.ToString() + "m";
        }

        #region Load&SaveData

        private void LoadData()
        {

        }

        private void SaveData()
        {

        }

        #endregion
    }
}
