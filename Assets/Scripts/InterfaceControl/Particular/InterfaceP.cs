using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InterfaceP : MonoBehaviour
{
    [Header("Basic Interfaces TMPro")]
    public TMP_Text nameTXTP;
    public TMP_Text hpTXTP;
    Players playerData;

    // Start is called before the first frame update
    void Start()
    {
        playerData = GetComponentInParent<Players>();
        StartCoroutine(asignData(0.1f));
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nameTXTP != null)
        {
            nameTXTP.text = playerData.names;
        }
        if (hpTXTP != null)
        {
            hpTXTP.text = playerData.hp.ToString();
        }
        
    }
        IEnumerator asignData(float waitTime)
       {
        yield return new WaitForSeconds(waitTime);

        if (nameTXTP != null)
        {
            nameTXTP.text = playerData.names;
        }
        if (hpTXTP != null)
        {
            hpTXTP.text = playerData.hp.ToString();
        }
        }
}
