using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;

public class Scoreboard : MonoBehaviour

{
    private TMP_Text score;
    private int scoreIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
      score = GetComponent<TMP_Text>();
        Pickup.Onpickup += Addscore;
    }

    // Update is called once per frame
    void Addscore()
    {
        scoreIndex += 50;
        score.text = "score:" + scoreIndex;
    }
}
