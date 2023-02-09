using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CityDropdown : MonoBehaviour
{
    public DepartamentDropdown DepatmentNum;
    public int NumberDepartment;
    public int locationNumber;
    public int definitiveLocationNumber;
    void Start()
    {
        
    }
    void Update()
    {
        NumberDepartment = DepatmentNum.DepartmentNumber;
        Debug.Log(NumberDepartment);
        if (NumberDepartment == 1)
        {
            locationNumber = 0;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Leticia");
            items.Add("Puerto Nariño");
            items.Add("El Encanto");
            items.Add("La Pedrera");
            items.Add("La Chorrera");
            items.Add("Mirití Paraná");
            items.Add("Puerto Alegría"); 
            items.Add("Tarapacá");
            items.Add("Puerto Arica");
            items.Add("La Victoria");
            items.Add("Puerto Santander");
            items.Add("Pacoa");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }

        if (NumberDepartment == 2)
        {
            locationNumber = 100;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Medellín");
            items.Add("Itagüi");
            items.Add("Bello");
            items.Add("Rionegro");
            items.Add("Envigado");
            items.Add("Santa Fé de Antioquia");
            items.Add("Copacabana");
            items.Add("Amalfi");
            items.Add("Barbosa");
            items.Add("Santa Rosa de Osos");
            items.Add("San Pedro");
            items.Add("Apartadó");
            items.Add("Marinilla");
            items.Add("Girardota");
            items.Add("Caucasia");
            items.Add("Turbo");
            items.Add("Jericó");
            items.Add("Yarumal");
            items.Add("Ituango");
            items.Add("Necoclí");
            items.Add("Arboletes");
            items.Add("La Estrella");
            items.Add("Chigorodó");
            items.Add("Sabaneta");
            items.Add("Puerto Berrío");
            items.Add("El Bagre");
            items.Add("Carepa");
            items.Add("Urrao");
            items.Add("Amagá");
            items.Add("Guarne");
            items.Add("San Jerónimo");
            items.Add("Caldas");
            items.Add("Ebéjico");
            items.Add("Abriaquí");
            items.Add("La Ceja");
            items.Add("Sopetrán");
            items.Add("Tarazá");
            items.Add("Remedios");
            items.Add("Sonsón");
            items.Add("Cáceres");
            items.Add("Don Matías");
            items.Add("Jardín");
            items.Add("Frontino");
            items.Add("Ciudad Bolívar");
            items.Add("Carolina del Príncipe");
            items.Add("Anzá");
            items.Add("Valdivia");
            items.Add("Entrerríos");
            items.Add("Belmira");
            items.Add("San Vicente");
            items.Add("El Carmen de Viboral");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }

        if (NumberDepartment == 3)
        {
            locationNumber = 200;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Barranquilla");
            items.Add("Soledad");
            items.Add("Baranoa");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }

        if (NumberDepartment == 4)
        {
            locationNumber = 300;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Cartagena");
            items.Add("Mompós");
            items.Add("Magangué");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }

        if (NumberDepartment == 5)
        {
            locationNumber = 400;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Tunja");
            items.Add("Duitama");
            items.Add("Paipa");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }

        if (NumberDepartment == 6)
        {
            locationNumber = 500;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Manizales");
            items.Add("Villamaría");
            items.Add("Salamina");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }

        if (NumberDepartment == 7)
        {
            locationNumber = 600;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Florencia");
            items.Add("Belen de Los Andaquies");
            items.Add("La Montañita");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }

        if (NumberDepartment == 8)
        {
            locationNumber = 700;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Yopal");
            items.Add("Paz de Ariporo");
            items.Add("Aguazul");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }

        if (NumberDepartment == 9)
        {
            locationNumber = 800;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Popayán");
            items.Add("Caloto");
            items.Add("Inza");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }

        if (NumberDepartment == 10)
        {
            locationNumber = 900;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Valledupar");
            items.Add("Aguachica");
            items.Add("Chiriguaná");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }

        if (NumberDepartment == 11)
        {
            locationNumber = 1000;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Quibdó");
            items.Add("Acandí");
            items.Add("Bellavista Bojayá");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }

        if (NumberDepartment == 12)
        {
            locationNumber = 1100;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Montería");
            items.Add("Cereté");
            items.Add("Los Córdobas");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }

        if (NumberDepartment == 13)
        {
            locationNumber = 1200;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Soacha");
            items.Add("Zipaquirá");
            items.Add("Mosquera");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }

        if (NumberDepartment == 14)
        {
            locationNumber = 1300;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Inírida");
            items.Add("Barranco Minas");
            items.Add("Cacahual");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }

        if (NumberDepartment == 15)
        {
            locationNumber = 1400;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("San José Del Guaviare");
            items.Add("El Retorno");
            items.Add("Miraflores");
            items.Add("Calamar");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }

        if (NumberDepartment == 16)
        {
            locationNumber = 1500;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Neiva");
            items.Add("Pitalito");
            items.Add("Garzón");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }

        if (NumberDepartment == 17)
        {
            locationNumber = 1600;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Riohacha");
            items.Add("Maicao");
            items.Add("Uribia");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }

        if (NumberDepartment == 18)
        {
            locationNumber = 1700;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Santa Marta");
            items.Add("Aracataca");
            items.Add("Ciénaga");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }

        if (NumberDepartment == 19)
        {
            locationNumber = 1800;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Villavicencio");
            items.Add("Acacías");
            items.Add("Puerto López");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }

        if (NumberDepartment == 20)
        {
            locationNumber = 1900;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Pasto");
            items.Add("Tumaco");
            items.Add("Ipiales");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }

        if (NumberDepartment == 21)
        {
            locationNumber = 2000;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Cúcuta");
            items.Add("Ocaña");
            items.Add("Pamplona");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }

        if (NumberDepartment == 22)
        {
            locationNumber = 2100;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Mocoa");
            items.Add("Puerto Asís");
            items.Add("Valle Del Guamuez");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }

        if (NumberDepartment == 23)
        {
            locationNumber = 2200;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Armenia");
            items.Add("Salento");
            items.Add("Calarcá");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }

        if (NumberDepartment == 24)
        {
            locationNumber = 2300;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Pereira");
            items.Add("La Virginia");
            items.Add("Dosquebradas");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }

        if (NumberDepartment == 25)
        {
            locationNumber = 2400;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("San Andrés");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }

        if (NumberDepartment == 26)
        {
            locationNumber = 2500;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Bucaramanga");
            items.Add("Girón");
            items.Add("Floridablanca");
            items.Add("San Gil");
            items.Add("Piedecuesta");
            items.Add("Barrancabermeja");
            items.Add("Barichara");
            items.Add("zapatoca");
            items.Add("Lebrija");
            items.Add("Rionegro");
            items.Add("Velez");
            items.Add("Los Santos");
            items.Add("Barbosa");
            items.Add("El Playon");
            items.Add("Málaga");
            items.Add("Socorro");
            items.Add("Puente Nacional");
            items.Add("Guaca");
            items.Add("San Andrés");
            items.Add("El Carmen de Chucurí");
            items.Add("Villanueva");
            items.Add("Mogotes");
            items.Add("Charalá");
            items.Add("Tona");
            items.Add("Cimitarra");
            items.Add("Aratoca");
            items.Add("San Vicente de Chucurí");
            items.Add("Curití");
            items.Add("Simacota");
            items.Add("Cerrito");
            items.Add("Cepita");
            items.Add("Capitanejo");
            items.Add("Puerto Wilches");
            items.Add("Oiba");
            items.Add("Betulia");
            items.Add("Suratá");
            items.Add("Jordan");
            items.Add("Charta");
            items.Add("Palmar");
            items.Add("Bolívar");
            items.Add("Matanza");
            items.Add("Sucre");
            items.Add("Concepción");
            items.Add("Vetas");
            items.Add("Pinchote");
            items.Add("Aguada");
            items.Add("Coromoro");
            items.Add("Landázuri");
            items.Add("Santa Bárbara");
            items.Add("Sabana de Torres");
            items.Add("Florián");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }
        if (NumberDepartment == 27)
        {
            locationNumber = 2600;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Sincelejo");
            items.Add("Corozal");
            items.Add("Santiago de Tolú");
            items.Add("Los Palmitos");
            items.Add("Covenas");
            items.Add("Sampués");
            items.Add("Tolú Viejo");
            items.Add("Colosó");
            items.Add("Chalán");
            items.Add("Sincé");
            items.Add("Morroa");
            items.Add("Ovejas");
            items.Add("El Roble");
            items.Add("Galeras");
            items.Add("Betulia");
            items.Add("San Pedro");
            items.Add("Caimito");
            items.Add("Palmito");
            items.Add("Majagual");
            items.Add("San Benito Abad");
            items.Add("San Onofre");
            items.Add("San Marcos");
            items.Add("Guarandá");
            items.Add("La Unión");
            items.Add("Buenavista");
            items.Add("Majagual");
            items.Add("Sucre");
            items.Add("Chinú");
            items.Add("Sucre");
            items.Add("Achi");
            items.Add("Purísima");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }
        if (NumberDepartment == 28)
        {
            locationNumber = 2700;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Ibagué");
            items.Add("El Espinal");
            items.Add("Mariquita");
            items.Add("Honda");
            items.Add("Libano");
            items.Add("Lérida");
            items.Add("Cajamarca");
            items.Add("Chaparral");
            items.Add("Melgar");
            items.Add("Venadillo");
            items.Add("Guamo");
            items.Add("Natagaima");
            items.Add("Armero");
            items.Add("Saldaña");
            items.Add("Fresno");
            items.Add("Falan");
            items.Add("Alvarado");
            items.Add("Anazoátegui");
            items.Add("Ambelama");
            items.Add("Coyaima");
            items.Add("Villahermosa");
            items.Add("Palocabildo");
            items.Add("Ataco");
            items.Add("Coello");
            items.Add("Herveo");
            items.Add("Rovira");
            items.Add("Ortega");
            items.Add("Flandes");
            items.Add("Purificación");
            items.Add("Rioblanco");
            items.Add("Santa Isabel");
            items.Add("San Antonio");
            items.Add("Carmen de Apicalá");
            items.Add("Prado");
            items.Add("Planadas");
            items.Add("Murillo");
            items.Add("Cunday");
            items.Add("Alpujarra");
            items.Add("Casablanca");
            items.Add("Villarrica");
            items.Add("Iconozco");
            items.Add("Suarez");
            items.Add("Valle de San Juan");
            items.Add("Dolores");
            items.Add("San Luis");
            items.Add("Ronces Valles");
            items.Add("Guayabal");
            items.Add("Piedras");
            items.Add("Armero");
            items.Add("Piedras");
            items.Add("Anzoategui");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }
        if (NumberDepartment == 29)
        {
            locationNumber = 2800;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Cali");
            items.Add("Buga");
            items.Add("Palmira");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }
        if (NumberDepartment == 30)
        {
            locationNumber = 2900;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Mitú");
            items.Add("Taraira");
            items.Add("Carurú");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }

        if (NumberDepartment == 31)
        {
            locationNumber = 3000;
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            List<string> items = new List<string>();
            items.Add("Seleccionar");
            items.Add("Puerto Carreño");
            items.Add("Cumaribo");
            items.Add("La Primavera");
            items.Add("Santa Rosalía");
            items.Add("San José de Maipures");
            items.Add("Las Gaviotas");
            items.Add("San José de Ocune");

            foreach (var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);

            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }
    }

    void DropdownItemSelected(Dropdown dropdown)
    {
        int index = dropdown.value;

        Debug.Log(dropdown.options[index].text);
        definitiveLocationNumber = locationNumber + index;
    }

}
