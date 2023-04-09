using UnityEngine;

namespace Cor.SDK
{
    public class AppMetricaAnalytics : MonoBehaviour
    {
        #region Variables

        [SerializeField] private int _levelNumber;
        [SerializeField] private int _levelName;
        [SerializeField] private int _levelCount;
        [SerializeField] private int _levelLoop;
        [SerializeField] private int _loopAttempt;
        [SerializeField] private int _time;

        #endregion

        public void LevelStartEvent()
        {
            _time = (int)Time.time;

            var eventVariables = "{\"level_number\":\"" + _levelNumber + "\"," +
                               "\"level_name\":\"" + _levelName + "\"," +
                               "\"level_count\":\"" + _levelCount + "\"," +
                               "\"level_diff\":\"" + "easy" + "\"," +
                               "\"level_loop\":\"" + _levelLoop + "\"," +
                               "\"level_random\":\"" + 0 + "\"," +
                               "\"level_type\":\"normal\"," +
                               "}";

            AppMetrica.Instance.ReportEvent("level_start", eventVariables);
            AppMetrica.Instance.SendEventsBuffer();
        }

        public void LevelFinishEvent(string _levelResult)
        {
            _time = (int)(Time.time - _time);

            var eventVariables = "{\"level_number\":\"" + _levelNumber + "\"," +
                                  "\"level_name\":\"" + _levelName + "\"," +
                                  "\"level_count\":\"" + _levelCount + "\"," +
                                   "\"level_diff\":\"" + "easy" + "\"," +
                                  "\"level_loop\":\"" + _levelLoop + "\"," +
                                  "\"level_random\":\"" + 0 + "\"," +
                                  "\"level_type\":\"normal\"," +
                                  "\"result\":\"" + _levelResult + "\"," +
                                  "\"time\":\"" + _time + "\"," +
                                  "\"continue\":\"0\"," +
                                  "}";

            AppMetrica.Instance.ReportEvent("level_finish", eventVariables);
            AppMetrica.Instance.SendEventsBuffer();
        }

        public void NewLevel()
        {
            _levelNumber++;
            _levelName++;
            SaveData();
        }

        public void NewAttempt()
        {
            _levelCount++;
            SaveData();
        }

        public void LevelLoop()
        {
            _loopAttempt++;
            if (_loopAttempt >= 12)
            {
                _levelLoop++;
                _levelName = 1;
                _loopAttempt = 0;
            }
            SaveData();
        }

        #region Load&Save

        public void LoadData()
        {
            _levelNumber = ES3.Load("_levelNumber", _levelNumber);
            _levelName = ES3.Load("_levelName", _levelName);
            _levelCount = ES3.Load("_levelCount", _levelCount);
            _levelLoop = ES3.Load("_levelLoop", _levelLoop);
            _loopAttempt = ES3.Load("_loopAttempt", _loopAttempt);
        }

        private void SaveData()
        {
            ES3.Save("_levelNumber", _levelNumber);
            ES3.Save("_levelName", _levelName);
            ES3.Save("_levelCount", _levelCount);
            ES3.Save("_levelLoop", _levelLoop);
            ES3.Save("_loopAttempt", _loopAttempt);
        }

        #endregion
    }
}
