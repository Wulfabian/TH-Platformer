using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSign : MonoBehaviour
{
    //Fixar en public GameObject så att jag kan dra in de vapnet jag vill ha
    public GameObject weaponPrefab;
    //Döper GroundCheck scriptet till "groundcheck"
    private GroundCheck groundCheck;
    //En renderer
    public Renderer rend;
    //Skapar en float som man kan välja i vilken vinkel vapnet ska vara
    public float weaponAngle;
    //Skapar en bool som säger om man är åt vänster eller ej
    public bool isleft;

    // Use this for initialization
    void Start()
    {
        //Hämtar renderern
        rend = GetComponent<Renderer>();
        //Och sätter den sedan till falsk för att man inte ska starta med ett vapen
        rend.enabled = false;
    }

    private void Update()
    {
        //Aktiverar funktionen
        WeaponSideSwitch();
    }
    //Skapar en funktion som gör att skylten flyttar sig så att den alltid är riktat åt det hållet man går
    void WeaponSideSwitch()
    {
        //Om man är riktad åt vänster så kommer alla localPosition / Scale och vinkelns X vara negativa 
        if (isleft)
        {
            transform.localPosition = new Vector3(Mathf.Abs(transform.localPosition.x) * -1, (transform.localPosition.y), (transform.localPosition.z));
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x) * -1, (transform.localScale.y), (transform.localScale.z));
            transform.localEulerAngles = new Vector3(Mathf.Abs(transform.localEulerAngles.x) * -1, (transform.localEulerAngles.y), 360 - weaponAngle);

        }
        //OM man inte är riktad åt vänster så är alla X possitiva istället förutom vinkeln som fortfarande är negativ
        if (!isleft)
        {
            transform.localPosition = new Vector3(Mathf.Abs(transform.localPosition.x), (transform.localPosition.y), (transform.localPosition.z));
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), (transform.localScale.y), (transform.localScale.z));
            transform.localEulerAngles = new Vector3(Mathf.Abs(transform.localEulerAngles.x) * -1, (transform.localEulerAngles.y), (weaponAngle));
        }
    }

}
