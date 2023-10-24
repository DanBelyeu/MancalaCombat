using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MancalaController : MonoBehaviour
{

    [SerializeField]
    TMP_Text[] cupLabels;

    private int[] cupContents = {3, 3, 3, 3, 3, 3};
    public void onButtonClick(int cupNumber)
    {
        distributeCupContents(cupNumber-1);
        updateCupLabels();
    }

    private void distributeCupContents(int selectedCup) {
        int numCups = cupContents.Length;
        int removedTokens = cupContents[selectedCup];

        cupContents[selectedCup] = 0;

        for (int i=1; i<=removedTokens; i++) {
            cupContents[(selectedCup+i) % numCups] += 1;
        }
    }

    private void updateCupLabels() {
        for (int i=0; i<cupContents.Length; i++) {
            cupLabels[i].text = cupContents[i].ToString();
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        updateCupLabels();
    }
}
