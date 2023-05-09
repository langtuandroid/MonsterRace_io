using System;
using UnityEngine;
using UnityEngine.UI;

namespace Cor
{
    public class Timer : MonoBehaviour
    {
        DateTime startTime;
        TimeSpan currentTime;
        TimeSpan oneDay = new TimeSpan(24, 0, 0);
        public Text text;
        void Start()
        {
            StartTime();
        }

        void Update()
        {
            currentTime = DateTime.UtcNow - startTime;
            if (currentTime >= oneDay)
            {
                StartTime();
            }
            text.text = GetTime(currentTime);
        }

        private void StartTime()
        {
            startTime = DateTime.UtcNow;
        }

        private string GetTime(TimeSpan time)
        {
            TimeSpan countdown = oneDay - time;
            return countdown.Hours.ToString() + "h" + ":" + countdown.Minutes.ToString() + "m";
        }
    }
}
