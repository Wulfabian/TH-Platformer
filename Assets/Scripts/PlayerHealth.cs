using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    //Fixar en float som är maxHealth. och sätter den till 100 så att man har 100hp
    public float maxHealth = 100;
    //Fixar en float som är currentHealth som sedan visar hur mycket hp man har
    public float currentHealth;
    //Fixar en text som jag döper till HPtext för den kommer visa hur mycket HP man har
    public Text HPtext;
   // public Slider healthBar;
    HurtObject skada;
    //Healthen
    float Health()
    {
        //Man dividerar dessa två variabler för att få det procentuella värdet av sitt hp
        return currentHealth / maxHealth;
    }

    // Use this for initialization
    void Start()
    {
        //När det börjar så kommer sitt Hp sättas till max
        currentHealth = maxHealth;
        //Uppdatera sin text
        UpdateText();
        //Hittar scriptet "HurtObject"
        skada = FindObjectOfType<HurtObject>();
      //  healthBar.value = Health();
    }
    //När man först nuddar"
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Om det man nuddar är taggat med "Enemy"
        if (collision.gameObject.tag == "Enemy")
        {
            //Funktionen losehealths float sätts till det fienden skadar
            LoseHealth(skada.dmgdealing);
        }
    }
    // Update is called once per frame
    void Update()
    {
        //Om man har mindre eller = 0 hp så laddar man om scenen man är på
        if (currentHealth <= 0)
        {
            Scene active = SceneManager.GetActiveScene();
            SceneManager.LoadScene(active.name);
        }
    }
    //Skapar en funktion som bestämmer hur mycket HP man tappar
    public void LoseHealth(float damageValue)
    {
        //tar bort skada från sitt hp
        currentHealth -= damageValue;
        // healthBar.value = Health();
        UpdateText();
    }
    //En funktion som uppdaterar texten
    void UpdateText()
    {
        //Bestämmer vad som ska stå i texten
        HPtext.text = string.Format("HP {0} / 100", currentHealth);
    }
    
}
