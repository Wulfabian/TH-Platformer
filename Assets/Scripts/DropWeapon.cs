using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropWeapon : MonoBehaviour
{
    WeaponSign weapon;
    public GameObject weaponPrefab;
    public Transform player;
    // Use this for initialization
    void Start()
    {
        weapon = FindObjectOfType<WeaponSign>();
    }

    // Update is called once per frame
    void Update()
    {
        //Anävnder funktionen "WeaponDrop" varje update
        WeaponDrop();
    }
    //Skapar en funktion som heter "WeaponDrop"
    void WeaponDrop()
    {
        //om man klickar på Q så händer
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Om "weapon"'s rend är enabled så skapas en prefab av sign på spelarens position och renden blir sedan false
            if (weapon.rend.enabled == true)
            {
                Instantiate(weaponPrefab,player.position,Quaternion.identity);
                weapon.rend.enabled = false;
            }
            //Om inte
            else
            {
                //printa att man inte håller i något vapen
                Debug.Log("Inget vapen i handen");
            }
        }
    }
}
