using System;
using TMPro;
using UnityEngine;

public class YearValidator : MonoBehaviour
{
    public TMP_InputField inputField;

    private int minYear = 1900;
    private int maxYear;

    void Start()
    {
        maxYear = DateTime.Now.Year;
        inputField.onEndEdit.AddListener(ValidateYear);
    }

    void ValidateYear(string value)
    {
        if (string.IsNullOrEmpty(value))
            return;

        int year;

        if (int.TryParse(value, out year))
        {
            year = Mathf.Clamp(year, minYear, maxYear);
            inputField.text = year.ToString();
        }
        else
        {
            inputField.text = minYear.ToString();
        }
    }
}
