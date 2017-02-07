using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public List<GameObject> Heroes;
    public int Gold;
    public int Reputation;
    public Text goldText;
    public Text reputationText;
    // Use this for initialization
    void Start()
    {
        Heroes = new List<GameObject>();
        Gold = 0;
        Reputation = 0;
    }

    // Update is called once per frame
    void Update()
    {
        goldText.text = Gold.ToString();
        reputationText.text = Reputation.ToString();
    }
}
