using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class hp : MonoBehaviour
{

    public TextMeshProUGUI valueText;
    public void UpdateHp(int nowHp, int maxHp){
        valueText.text = nowHp.ToString()+" / "+maxHp.ToString();
    }
}
