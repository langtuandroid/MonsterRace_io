using System.Collections.Generic;
using UnityEngine;

namespace Cor
{
    public class WeaponSpawner : MonoBehaviour
    {
        #region Variables

        [SerializeField] TestLobby testLobby;
        [SerializeField] List<GameObject> weaponPrefabs = new List<GameObject>();
        [SerializeField] private int indexPlayerWeapon;

        #endregion

        private void Start()
        {
            LoadData();
            if (testLobby != null) testLobby.ActiveWeapon();
        }

        public int GetIndex()
        {
            return indexPlayerWeapon;
        }

        public void SetWeapon(int index)
        {
            indexPlayerWeapon = index;
            testLobby.ActiveWeapon();
            SaveData();
        }

        public Weapon SpawnWeapon(Transform point, int indexWeapon)
        {
            GameObject newWeapon = Instantiate(weaponPrefabs[indexWeapon], point.position, point.rotation);
            newWeapon.transform.parent = point.parent;
            return newWeapon.GetComponent<Weapon>();
        }

        #region Load&SaveData

        private void LoadData()
        {
            indexPlayerWeapon = ES3.Load("indexPlayerWeapon", indexPlayerWeapon);
        }

        private void SaveData()
        {
            ES3.Save("indexPlayerWeapon", indexPlayerWeapon);
        }

        #endregion
    }
}
