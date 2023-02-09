using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dropdown1OtherSymptoms : MonoBehaviour
{
    void Start()
    {
        var dropdown = transform.GetComponent<Dropdown>();

        dropdown.options.Clear();

        List<string> items = new List<string>();
        items.Add("Seleccionar");
        items.Add("Disnea de esfuerzo");
        items.Add("Disnea decúbito supino");
        items.Add("Disnea paroxística");
        items.Add("Disnea de reposo");

        foreach (var item in items)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = item });
        }

        DropdownItemSelected(dropdown);

        dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
    }

    void DropdownItemSelected(Dropdown dropdown)
    {
        int index = dropdown.value;

        MiddleManager.typeOfDyspnea2 = index;
    }
}
