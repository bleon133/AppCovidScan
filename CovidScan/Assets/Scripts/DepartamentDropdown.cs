using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DepartamentDropdown : MonoBehaviour
{
    public int DepartmentNumber;

    void Start()
    {
        var dropdown = transform.GetComponent<Dropdown>();

        dropdown.options.Clear();

        List<string> items = new List<string>();
        items.Add("Seleccionar");
        items.Add("Amazonas");
        items.Add("Antioquía");
        items.Add("Atlántico");
        items.Add("Bolivar");
        items.Add("Boyacá");
        items.Add("Caldas");
        items.Add("Caquetá");
        items.Add("Casanare");
        items.Add("Cauca");
        items.Add("Cesar");
        items.Add("Chocó");
        items.Add("Córdoba");
        items.Add("Cundinamarca");
        items.Add("Guainía");
        items.Add("Guaviare");
        items.Add("Huila");
        items.Add("La Guajira");
        items.Add("Magdalena");
        items.Add("Meta");
        items.Add("Nariño");
        items.Add("Norte de Santander");
        items.Add("Putumayo");
        items.Add("Quindío");
        items.Add("Risaralda");
        items.Add("San Andrés");
        items.Add("Santander");
        items.Add("Sucre");
        items.Add("Tolima");
        items.Add("Valle del Cauca");
        items.Add("Vaupés");
        items.Add("Vichada");

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

        Debug.Log(dropdown.options[index].text);

        DepartmentNumber = index;
    }

}
