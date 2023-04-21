using System.Collections.Generic;
using UnityEngine;

namespace Cor
{
    public class WeaponSpawner : MonoBehaviour
    {
        #region Variables

        [SerializeField] List<GameObject> weaponPrefabs = new List<GameObject>();

        #endregion

        public Weapon SpawnWeapon(Transform point, int indexWeapon)
        {
            GameObject newWeapon = Instantiate(weaponPrefabs[indexWeapon], point.position, point.rotation);
            newWeapon.transform.parent = point.parent;
            return newWeapon.GetComponent<Weapon>();
        }
    }
}
