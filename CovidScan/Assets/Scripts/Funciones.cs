using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class Funciones : MonoBehaviour
{
    public GameObject[] screen;

    // ::Variables::
    //Email
    public InputField emailRegistryInput;
    public InputField emailLoginInput;

    //Password
    public InputField passwordLogin;
    public InputField passwordRegister;
    public InputField passwordRepeatRegister;
    string password = "";

    //Errores
    public Text Error2;
    public Text Error3;
    public Text Error4;

    //Names and Last Names
    public InputField namesInput;
    public InputField lastNamesInput;

    //CellPhone
    public InputField cellPhoneInput;

    //Personal Information
    public InputField identificationCardInput;
    public Toggle TI;
    public Toggle CC;
    public Toggle CE;
    public int identificationType;
    public InputField addressInput;

    //Avatars
    public int numberAvatar;

    //Sonidos

    //Toggles
    public Toggle cancerToggle;
    public Toggle decompensatedThyroidToggle;
    public Toggle kidneyOrLiverToggle;
    public Toggle immuneSystemToggle;
    public Toggle rheumatoidToggle;
    public Toggle vihAndSidaToggle;
    public Toggle pregnancyToggle;
    public Toggle diabetesMellitusToggle;
    public Toggle badNutritionToggle;
    public Toggle respiratorySystemToggle;
    public Toggle cardiovascularSystemToggle;
    public Toggle organTransplantToggle;
    public Toggle useOfCorticosteroidsToggle;
    public Toggle positiveCovid19Toggle;
    public Toggle possibleCovid19Toggle;
    public Toggle TermsAndConditionsToogle;

    //Limpieza
    public Button LimpBoton;

    //connections between scripts
    public IpsDropdown IpsScript;
    public EpsDropdown EpsScript;
    public CityDropdown cityScript;

    public int numberIps;
    public int numberEps;
    public int numberlocation;

    int verificationEmail;
    int verificationIdentification;

    void Start() //Pantalla de Inicio
    {
        for (int i = 0; i < screen.Length; i++)
        {
            screen[i].SetActive(false);
        }
        screen[0].SetActive(true);

        LimpBoton.onClick.AddListener(Limpieza);
    }

    void Update()
    {
        if(MiddleManager.error1 == 1)
        {
            verificationEmail = 1;
        }
        else
        {
            verificationEmail = 0;
        }

        if (MiddleManager.error2 == "")
        {
            verificationIdentification = 1;
        }
        else
        {
            verificationIdentification = 0;
        }

    }
    public void Login()
    {
        for (int i = 0; i < screen.Length; i++)
        {
            screen[i].SetActive(false);
        }
        screen[1].SetActive(true);
    }

    public void Cuenta()
    {
        for (int i = 0; i < screen.Length; i++)
        {
            screen[i].SetActive(false);
        }
        screen[2].SetActive(true);
    }

    public void Registry1()
    {
        numberIps = IpsScript.IpsNumber;
        numberEps = EpsScript.EpsNumber;
        password = passwordRegister.text;

        if (passwordRegister.text != "" && emailRegistryInput.text != "" && identificationCardInput.text != "")
        {
            if (password.Length >= 6)
            {
                if(identificationCardInput.text.Length >= 6)
                {
                    if (passwordRegister.text == passwordRepeatRegister.text)
                    {
                        if (TI.isOn || CC.isOn || CE.isOn)
                        {
                            if (numberIps != 0 && numberEps != 0)
                            {
                                if (verificationEmail == 1)
                                {
                                    if (verificationIdentification == 1)
                                    {
                                        for (int i = 0; i < screen.Length; i++)
                                        {
                                            screen[i].SetActive(false);
                                        }
                                        screen[3].SetActive(true);
                                    }
                                    else
                                    {
                                        Error2.text = "El documento ya existe.";
                                    }
                                }
                                else
                                {
                                    Error2.text = "El correo ya existe.";
                                }
                            }
                            else
                            {
                                Error2.text = "Falta seleccionar EPS y/o IPS.";
                            }
                            if (TI.isOn)
                            {
                                identificationType = 1;
                            }
                            if (CC.isOn)
                            {
                                identificationType = 2;
                            }
                            if (CE.isOn)
                            {
                                identificationType = 3;
                            }
                        }
                        else
                        {
                            Error2.text = "Seleccionar su tipo de identificación.";
                        }

                    }
                    else
                    {
                        Error2.text = "Las contraseñas no coinciden.";
                    }
                }
                else
                {
                    Error2.text = "Digitar un documento valido.";
                }
            }
            else
            {
                Error2.text = "Contraseña mayor a 6 caracteres";
            }
        }
        else
        {
            Error2.text = "Debes llenar todos los campos.";
        }
    }

    public void IdentificationCardTi()
    {
        if (TI.isOn)
        {
            CE.isOn = false;
            CC.isOn = false;
        }
    }

    public void IdentificationCardCc()
    {
        if (CC.isOn)
        {
            TI.isOn = false;
            CE.isOn = false;
        }
    }

    public void IdentificationCardCe()
    {
        if (CE.isOn)
        {
            TI.isOn = false;
            CC.isOn = false;
        }
    }

    public void Condiciones ()
    {
        Application.OpenURL("https://terminosycondiciones-covidscan.blogspot.com/");
    }

    public void RegistryPathology()
    {
        for (int i = 0; i < screen.Length; i++)
        {
            screen[i].SetActive(false);
        }
        screen[4].SetActive(true);
    }

    public void Registry2() //Registro
    {
        numberlocation = cityScript.definitiveLocationNumber;
        if (namesInput.text != "" && lastNamesInput.text != "" && cellPhoneInput.text != "" && addressInput.text != "")
        {
            if(cellPhoneInput.text.Length >= 10)
            {
                if (numberlocation != 0 && numberlocation != 100 && numberlocation != 200 && numberlocation != 300 && numberlocation != 400 && numberlocation != 500 && numberlocation != 600 && numberlocation != 700 && numberlocation != 800 && numberlocation != 900 && numberlocation != 1000 && numberlocation != 1100 && numberlocation != 1200 && numberlocation != 1300 && numberlocation != 1400 && numberlocation != 1500 && numberlocation != 1600 && numberlocation != 1700 && numberlocation != 1800 && numberlocation != 1900 && numberlocation != 2000 && numberlocation != 2100 && numberlocation != 2200 && numberlocation != 2300 && numberlocation != 2400 && numberlocation != 2500 && numberlocation != 2600 && numberlocation != 2700 && numberlocation != 2800 && numberlocation != 2900 && numberlocation != 3000)
                {
                    if (TermsAndConditionsToogle.isOn)
                    {
                        for (int i = 0; i < screen.Length; i++)
                        {
                            screen[i].SetActive(false);
                        }
                        screen[4].SetActive(true);
                    }
                    else
                    {
                        Error3.text = "Debes aceptar condiciones.";
                    }
                }
                else
                {
                    Error3.text = "Falta seleccionar Departamento y/o Ciudad.";
                }
            }
            else
            {
                Error3.text = "Digitar un telefono valido.";
            }
        }
        else
        {
            Error3.text = "Debes llenar todos los campos.";
        }
    }

    public void Pathology(int numAvatar) //Elegir Avatar
    {
        numberAvatar = numAvatar;
        if (positiveCovid19Toggle.isOn || possibleCovid19Toggle.isOn)
        {
            for (int i = 0; i < screen.Length; i++)
            {
                screen[i].SetActive(false);
            }
            screen[5].SetActive(true);
        }
        else
        {
            Error4.text = "Debe selecionar si es caso positivo o posible.";
        }

        // Patologias
        
        if (cancerToggle.isOn)
        {
            MiddleManager.numberCancer = 1;
        }
        else
        {
            MiddleManager.numberCancer = 0;
        }
        if (diabetesMellitusToggle.isOn)
        {
            MiddleManager.numberMellitusDiabetes = 1;
        }
        else
        {
            MiddleManager.numberMellitusDiabetes = 0;
        }
        if (decompensatedThyroidToggle.isOn)
        {
            MiddleManager.numberUncompensatedThyroid = 1;
        }
        else
        {
            MiddleManager.numberUncompensatedThyroid = 0;
        }
        if (badNutritionToggle.isOn)
        {
            MiddleManager.numberBadNutrition = 1;
        }
        else
        {
            MiddleManager.numberBadNutrition = 0;
        }
        if (kidneyOrLiverToggle.isOn)
        {
            MiddleManager.numberKidneyOrLiver = 1;
        }
        else
        {
            MiddleManager.numberKidneyOrLiver = 0;
        }
        if (cardiovascularSystemToggle.isOn)
        {
            MiddleManager.numberCardiovascularSystem = 1;
        }
        else
        {
            MiddleManager.numberCardiovascularSystem = 0;
        }
        if (immuneSystemToggle.isOn)
        {
            MiddleManager.numberInmuneSystem = 1;
        }
        else
        {
            MiddleManager.numberInmuneSystem = 0;
        }
        if (respiratorySystemToggle.isOn)
        {
            MiddleManager.numberRespiratorySystem = 1;
        }
        else
        {
            MiddleManager.numberRespiratorySystem = 0;
        }
        if (rheumatoidToggle.isOn)
        {
            MiddleManager.numberRheumatoid = 1;
        }
        else
        {
            MiddleManager.numberRheumatoid = 0;
        }
        if (organTransplantToggle.isOn)
        {
            MiddleManager.numberOrganTransplant = 1;
        }
        else
        {
            MiddleManager.numberOrganTransplant = 0;
        }
        if (vihAndSidaToggle.isOn)
        {
            MiddleManager.numberVihOrSida = 1;
        }
        else
        {
            MiddleManager.numberVihOrSida = 0;
        }
        if (useOfCorticosteroidsToggle.isOn)
        {
            MiddleManager.numberUseCorticosteroids = 1;
        }
        else
        {
            MiddleManager.numberUseCorticosteroids = 0;
        }
        if (pregnancyToggle.isOn)
        {
            MiddleManager.numberPregnancy = 1;
        }
        else
        {
            MiddleManager.numberPregnancy = 0;
        }

        // Positivo y Posible

        if (positiveCovid19Toggle.isOn)
        {
            MiddleManager.numberPositiveCovid19 = 1;
            MiddleManager.numberPossiblyCovid19 = 0;
        }
        else if (possibleCovid19Toggle.isOn)
        {
            MiddleManager.numberPossiblyCovid19 = 1;
            MiddleManager.numberPositiveCovid19 = 0;
        }   
    }

    public void PositiveToggle()
    {
        if (positiveCovid19Toggle.isOn)
        {
            possibleCovid19Toggle.isOn = false;
        }
    }

    public void PossibleToggle()
    {
        if (possibleCovid19Toggle.isOn)
        {
            positiveCovid19Toggle.isOn = false;
        }
    }

    public void Limpieza()
    {
        emailLoginInput.text = "";
        passwordLogin.text = "";
        passwordRegister.text = "";
        passwordRepeatRegister.text = "";
        namesInput.text = "";
        lastNamesInput.text = "";
        emailRegistryInput.text = "";
        cellPhoneInput.text = "";
        addressInput.text = "";
        identificationCardInput.text = "";
        cancerToggle.isOn = false;
        diabetesMellitusToggle.isOn = false;
        decompensatedThyroidToggle.isOn = false;
        badNutritionToggle.isOn = false;
        kidneyOrLiverToggle.isOn = false;
        cardiovascularSystemToggle.isOn = false;
        immuneSystemToggle.isOn = false;
        respiratorySystemToggle.isOn = false;
        rheumatoidToggle.isOn = false;
        organTransplantToggle.isOn = false;
        vihAndSidaToggle.isOn = false;
        useOfCorticosteroidsToggle.isOn = false;
        pregnancyToggle.isOn = false;
        positiveCovid19Toggle.isOn = false;
        possibleCovid19Toggle.isOn = false;
        TermsAndConditionsToogle.isOn = false;
        TI.isOn = false;
        CC.isOn = false;
        CE.isOn = false;
    }
}