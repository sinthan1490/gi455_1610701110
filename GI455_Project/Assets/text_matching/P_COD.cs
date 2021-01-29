using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P_COD : MonoBehaviour
{
    public Text lol;
    public InputField lolinput;

    public void mainsc()
    {
        string sc = lolinput.text;
        lol.text = sc;

        if (sc == "Pao")
        {
            lol.text = sc + " <color=Red>เปาเพื่อนลูกไอปื๊ด</color>";
        }

        if (sc == "Pued")
        {
            lol.text = sc + " <color=Red>ปื๊ดเมียโอ๋</color> ";
        }

        if (sc == "Palm")
        {
            lol.text = sc + " <color=Red>ปามซอยคุณพระ</color> ";
        }

        if (sc == "Plook")
        {
            lol.text = sc + " <color=Red>ปุ๊กชอบเด็ก</color> ";
        }

        if (sc == "Pom")
        {
            lol.text = sc + " <color=Red>ป๋อมขี้เมา</color> ";
        }


    }
   
}
