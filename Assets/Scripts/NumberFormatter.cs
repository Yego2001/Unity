using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberFormatter : MonoBehaviour
{
    public static string FormatNumber(double Number)
    {
        if (Number > 1000000000)
        {
            return (Number / 1000000000d).ToString("0.#") + "b";
        }
        if (Number > 1000000)
        {
            return (Number / 1000000d).ToString("0.#") + "m";
        }
        if (Number > 1000)
        {
            return (Number / 1000d).ToString("0.#") + "k";
        }
        return (Number.ToString());
    }
}
