using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cor
{
    public class TestLobby : MonoBehaviour
    {
        #region Variables

        [SerializeField] GameObject ball;
        [SerializeField] GameObject weapon;
        [SerializeField] MeshRenderer[] mesh;
        [SerializeField] GameObject[] weapons;
        [SerializeField] GameObject[] weapons2;

        private WeaponSpawner _weaponSpawner;

        #endregion

        private void Start()
        {
            _weaponSpawner = GameObject.FindObjectOfType<WeaponSpawner>();
            ActiveWeapon();
        }

        public void ActiveWeapon()
        {
            foreach(var i in weapons)
            {
                i.SetActive(false);
            }
            foreach (var i in weapons2)
            {
                i.SetActive(false);
            }

            weapons[_weaponSpawner.GetIndex()].SetActive(true);
            weapons2[_weaponSpawner.GetIndex()].SetActive(true);
        }

        public void SetTest(bool isWeapon)
        {
            if (isWeapon)
            {
                ball.SetActive(false);
                weapon.SetActive(true);
                return;
            }

            ball.SetActive(true);
            weapon.SetActive(false);
        }

        public void ColorBall(Color color)
        {
            foreach(var i in mesh)
            {
                i.material.color = color;
            }
        }
    }
}
