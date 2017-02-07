using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour
{

    public GameObject HeroPrefab;
    public GameController Controller;


    public void ButtonOnClick()
    {
        GameObject HeroPrefab = Instantiate(Resources.Load("PreFab/HeroPrefab")) as GameObject;
        Controller.Heroes.Add(HeroPrefab);
        var a = (Hero)HeroPrefab.GetComponent(typeof(Hero));
        Random rdn = new Random();
        a.StartHero("Teste");
    }
}
