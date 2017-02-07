using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class Hero : MonoBehaviour
{
    public HeroModel Model;


    void Update()
    {

    }
    public void StartHero(string name)
    {
        Model = new HeroModel();
        Model.Name = name;
    }

}
