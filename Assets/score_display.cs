using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_display : MonoBehaviour
{
    public Text lscore;
    public Text rscore;
    public GameObject score_manager;
    score_control scores;

    // Start is called before the first frame update
    void Start()
    {
        scores = score_manager.GetComponent<score_control>();
    }

    // Update is called once per frame
    void Update()
    {
        int right = scores.rscore;
        int left = scores.lscore;

        lscore.text = left.ToString();
        rscore.text = right.ToString();

        if (right > left)
        {
            lscore.color = Color.red;
            rscore.color = Color.green;
        }
        else if (left > right)
        {
            lscore.color = Color.green;
            rscore.color = Color.red;
        }
        else
        {
            lscore.color = Color.yellow;
            rscore.color = Color.yellow;
        }
    }
}
