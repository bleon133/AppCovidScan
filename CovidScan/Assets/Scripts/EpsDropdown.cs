using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EpsDropdown : MonoBehaviour
{
    public int EpsNumber;
    void Start()
    {
        var dropdown = transform.GetComponent<Dropdown>();

        dropdown.options.Clear();

        List<string> items = new List<string>();
        items.Add("Seleccionar");
        items.Add("Compensar(R.C)");
        items.Add("Sanitas(R.C)");
        items.Add("Famisanar(R.C)");
        items.Add("Salud Total(R.C)");
        items.Add("Sura(R.C)");
        items.Add("Nueva Eps(R.C)");
        items.Add("Coomeva(R.C)");
        items.Add("Cruz Blanca(R.C)");
        items.Add("Confenalco Valle(R.C)");
        items.Add("S.O.S(R.C)");
        items.Add("Aliansalud(R.C)");
        items.Add("Medimás(R.C)");
        items.Add("Comfenalco Antioquia(R.C)");
        items.Add("Mutual Ser(R.S)");
        items.Add("Convida(R.S)");
        items.Add("Cajacopi(R.S)");
        items.Add("Asmet Salud(R.S)");
        items.Add("Confasucre(R.S)");
        items.Add("Comfacor(R.S)");
        items.Add("Pijaos Salud(R.S)");
        items.Add("Capital Salud EPS-S(R.S)");
        items.Add("Comparta EPS-S(R.S)");
        items.Add("Nueva Eps(R.S)");
        items.Add("Capresoca(R.S)");
        items.Add("Ambuq(R.S)");
        items.Add("Comfaguajira(R.S)");
        items.Add("Mallamas(R.S)");
        items.Add("AIC-EPSI(R.S)");
        items.Add("Coosalud(R.S)");
        items.Add("No tengo EPS");

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

        Debug.Log(index);

        EpsNumber = index;
    }
}
