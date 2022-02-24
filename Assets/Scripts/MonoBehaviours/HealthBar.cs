using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBar : MonoBehaviour
{
    public HitPoints hitPoints;

    [HideInInspector]
    public Player character;

    public Image meterImage;

    public TMP_Text hpText;

    float maxHitPoints;
    // Start is called before the first frame update
    void Start()
    {
        maxHitPoints = character.maxHitPoints;
    }

    // Update is called once per frame
    void Update()
    {
        if(character != null)
        {
            meterImage.fillAmount = hitPoints.value / maxHitPoints;
            hpText.text = "HP: " + (meterImage.fillAmount * 100);
        }
    }
}
