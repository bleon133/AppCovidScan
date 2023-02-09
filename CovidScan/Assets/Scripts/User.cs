using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class User : MonoBehaviour
{
    public GameObject[] screen;

    //Limpieza
    public Button cleaningButton;

    //Perfil
    public Button finalAvatarButton;
    public Image finalAvatarImage;
    public Text nameText;
    public Text fullNameText;
    public Text emailText;
    public Text cellPhoneText;
    public Text birthdateText;
    DateTime birthdateUser;
    int ageUser;

    //Fiebre
    public Toggle yesHigherTemperature;
    public Toggle noHigherTemperature;
    public Toggle constant;
    public Toggle intermittent;
    public InputField typedTemperature;
    public Toggle responsibilityForResponses;
    public string TempSuperRep;
    public string ConstoInterm;
    public string NumTempCorpRep;
    public string timeFiebre = "";

    //Tos
    public Toggle yesSoreThroat;
    public Toggle noSoreThroat;
    public Toggle yesDryCough;
    public Toggle noDryCough;
    public Dropdown frequency;
    public Toggle yesCoughWithPhlegm;
    public Toggle noCoughWithPhlegm;
    public Dropdown frequency2;
    public Dropdown durationAttacks;
    public Toggle responsibilityForResponsesCough;

    //Frecuencia Cardiaca
    public Toggle yesInfant;
    public Toggle noInfant;
    public InputField beatsPerMinute;
    public InputField beatsPerMinuteLactating;
    public Toggle responsibilityForResponsesHeart;

    //Otros Sintomas
    public Toggle yesDifficultyBreathing;
    public Toggle noDifficultyBreathing;
    public Dropdown typeOfDyspnea;
    public Dropdown evolution;
    public Toggle yesfatigue;
    public Toggle nofatigue;
    public Toggle yesCongestionOrRunnyNose;
    public Toggle noCongestionOrRunnyNose;
    public Toggle yesPulseOximeter;
    public Toggle noPulseOximeter;
    public InputField pulseOximeter;
    public Toggle responsibilityForResponsesOtherSymtoms;

    //Errores
    public Text Error1;
    public Text Error2;
    public Text Error3;
    public Text Error4;

    void Start()
    {
        for (int i = 0; i < screen.Length; i++)
        {
            screen[i].SetActive(false);
        }
        screen[0].SetActive(true);

        cleaningButton.onClick.AddListener(Cleaning);  
    }

    // Update is called once per frame
    void Update()
    {
        nameText.text = MiddleManager.names;
        finalAvatarButton.image.sprite = Resources.Load<Sprite>("Avatars/avatar" + MiddleManager.avatar); //Visualización del Avatar en Perfil
    }

    public void MainMenu()
    {
        for (int i = 0; i < screen.Length; i++)
        {
            screen[i].SetActive(false);
        }
        screen[0].SetActive(true);
    }

    public void Profile() //Perfil del Paciente
    {
        for (int i = 0; i < screen.Length; i++)
        {
            screen[i].SetActive(false);
        }
        screen[1].SetActive(true);
        finalAvatarImage.sprite = Resources.Load<Sprite>("Avatars/avatar" + MiddleManager.avatar);
        fullNameText.text = MiddleManager.names + " " + MiddleManager.lastNames;
        emailText.text = MiddleManager.email;
        cellPhoneText.text = "Tel: " + MiddleManager.cellPhone;
        birthdateUser = Convert.ToDateTime(MiddleManager.birthdate);
        DateTime currentDate = DateTime.Today;
        ageUser = currentDate.Year - birthdateUser.Year;
        if (currentDate < birthdateUser.AddYears(ageUser)) ageUser--;
        birthdateText.text = "Edad: " + Convert.ToString(ageUser) + " " + "años";
    }

    public void InstructionsMenu()
    {
        for (int i = 0; i < screen.Length; i++)
        {
            screen[i].SetActive(false);
        }
        screen[2].SetActive(true);
    }

    public void TakeFever()
    {
        for (int i = 0; i < screen.Length; i++)
        {
            screen[i].SetActive(false);
        }
        screen[3].SetActive(true);
    }

    public void TakeCoughPeriodicity()
    {
        for (int i = 0; i < screen.Length; i++)
        {
            screen[i].SetActive(false);
        }
        screen[4].SetActive(true);
    }

    public void TakeHeartRate()
    {
        for (int i = 0; i < screen.Length; i++)
        {
            screen[i].SetActive(false);
        }
        screen[5].SetActive(true);
    }

    public void TakeOtherSymptoms()
    {
        for (int i = 0; i < screen.Length; i++)
        {
            screen[i].SetActive(false);
        }
        screen[6].SetActive(true);
    }

    public void DailyRegistryMenu()
    {
        for (int i = 0; i < screen.Length; i++)
        {
            screen[i].SetActive(false);
        }
        screen[7].SetActive(true);
    }

    public void FeverRegistry()
    {
        for (int i = 0; i < screen.Length; i++)
        {
            screen[i].SetActive(false);
        }
        screen[8].SetActive(true);
    }

    public void FeverRegistryDaily()
    {
        if (MiddleManager.dateFever != System.DateTime.UtcNow.ToLocalTime().ToString("M/d/yy"))
        {
            if(yesHigherTemperature.isOn || noHigherTemperature.isOn)
            {
                if(noHigherTemperature.isOn)
                {
                    Error1.text = "";
                    if (responsibilityForResponses.isOn)
                    {
                        Debug.Log(double.Parse(typedTemperature.text, System.Globalization.CultureInfo.InvariantCulture));
                        if (double.Parse(typedTemperature.text, System.Globalization.CultureInfo.InvariantCulture) >= 30 && double.Parse(typedTemperature.text, System.Globalization.CultureInfo.InvariantCulture) <= 40)
                        {
                            if (yesHigherTemperature.isOn)
                            {
                                MiddleManager.numberYesOrNoHigherTemperature = 1;
                            }
                            else if (noHigherTemperature.isOn)
                            {
                                MiddleManager.numberYesOrNoHigherTemperature = 0;
                            }

                            if (constant.isOn)
                            {
                                MiddleManager.numberconstantOrIntermittent = 1;
                            }
                            else if (intermittent.isOn)
                            {
                                MiddleManager.numberconstantOrIntermittent = 0;
                            }
                            else
                            {
                                MiddleManager.numberconstantOrIntermittent = 2;
                            }

                            MiddleManager.numbertypedTemperature = typedTemperature.text;
                            MiddleManager.dateFever = System.DateTime.UtcNow.ToLocalTime().ToString("M/d/yy");

                            for (int i = 0; i < screen.Length; i++)
                            {
                                screen[i].SetActive(false);
                            }
                            screen[7].SetActive(true);
                            MiddleManager.savecorrect = 1;
                        }
                        else
                        {
                            Error1.text = "Digitar una temperatura valida.";
                        }
                    }
                    else
                    {
                        Error1.text = "Debe responsabilizarse de sus respuestas.";
                    }
                }
                else if(yesHigherTemperature.isOn && (constant.isOn || intermittent.isOn))
                {
                    if (responsibilityForResponses.isOn)
                    {
                        if (Convert.ToDouble(typedTemperature.text) >= 30.10 && Convert.ToDouble(typedTemperature.text) <= 40.10)
                        {
                            if (yesHigherTemperature.isOn)
                            {
                                MiddleManager.numberYesOrNoHigherTemperature = 1;
                            }
                            else if (noHigherTemperature.isOn)
                            {
                                MiddleManager.numberYesOrNoHigherTemperature = 0;
                            }

                            if (constant.isOn)
                            {
                                MiddleManager.numberconstantOrIntermittent = 1;
                            }
                            else if (intermittent.isOn)
                            {
                                MiddleManager.numberconstantOrIntermittent = 0;
                            }
                            else
                            {
                                MiddleManager.numberconstantOrIntermittent = 2;
                            }

                            MiddleManager.numbertypedTemperature = typedTemperature.text;
                            MiddleManager.dateFever = System.DateTime.UtcNow.ToLocalTime().ToString("M/d/yy");

                            for (int i = 0; i < screen.Length; i++)
                            {
                                screen[i].SetActive(false);
                            }
                            screen[7].SetActive(true);
                            MiddleManager.savecorrect = 1;
                        }
                        else
                        {
                            Error1.text = "Digitar una temperatura valida.";
                        }
                    }
                    else
                    {
                        Error1.text = "Debe responsabilizarse de sus respuestas.";
                    }
                }
                else
                {
                    Error1.text = "Debe seleccionar si es constante o intermitente.";
                }
            }
            else
            {
                Error1.text = "Debes llenar los campos pedidos.";
            }
        }
        else
        {
            Error1.text = "No puede registrar sintomas de fiebre dos veces en un mismo día.";
        }
    }

    public void CleaningFever()
    {
        yesHigherTemperature.isOn = false;
        noHigherTemperature.isOn = false;
        constant.isOn = false;
        intermittent.isOn = false;
        typedTemperature.text = "";
        responsibilityForResponses.isOn = false;
        Error1.text = "";
        MiddleManager.dateFever = "";
        MiddleManager.numberYesOrNoHigherTemperature = 2;
        MiddleManager.numberconstantOrIntermittent = 2;
        MiddleManager.numbertypedTemperature = "0";
        MiddleManager.savecorrect = 0;
    }

    public void YesHigherTemperature()
    {
        if (yesHigherTemperature.isOn)
        {
            noHigherTemperature.isOn = false;
        }
    }

    public void NoHigherTemperature()
    {
        if (noHigherTemperature.isOn)
        {
            yesHigherTemperature.isOn = false;
        }
    }

    public void ConstantOrIntermittent()
    {
        if(noHigherTemperature.isOn)
        {
            constant.isOn = false;
            intermittent.isOn = false;
        }
        else if (yesHigherTemperature.isOn)
        {
            intermittent.interactable = yesHigherTemperature.isOn;
            constant.interactable = yesHigherTemperature.isOn;
        }
    }

    public void Constant()
    {
        if (constant.isOn)
        {
            intermittent.isOn = false;
        }
    }

    public void Intermittent()
    {
        if (intermittent.isOn)
        {
            constant.isOn = false;
        }
    }

    public void CoughPeriodicityRegistry()
    {
        for (int i = 0; i < screen.Length; i++)
        {
            screen[i].SetActive(false);
        }
        screen[9].SetActive(true);
    }

    public void CoughPeriodicityRegistryDaily()
    {
        if (MiddleManager.dateCough != System.DateTime.UtcNow.ToLocalTime().ToString("M/d/yy"))
        {
            if (yesSoreThroat.isOn || noSoreThroat.isOn)
            {
                if (yesSoreThroat.isOn)
                {
                    MiddleManager.throatPain = 1;
                }
                else if(noSoreThroat.isOn)
                {
                    MiddleManager.throatPain = 0;
                }
                if(yesDryCough.isOn)
                {
                    MiddleManager.dryCough = 1;
                    if (MiddleManager.frequencyDryCough2 != 0)
                    {
                        MiddleManager.frequencyDryCough = MiddleManager.frequencyDryCough2;
                        if (yesCoughWithPhlegm.isOn)
                        {
                            MiddleManager.coughwithphlegm = 1;
                            if (MiddleManager.frequency2 != 0 && MiddleManager.attackDuration2 != 0)
                            {
                                MiddleManager.frequency = MiddleManager.frequency2;
                                MiddleManager.attackDuration = MiddleManager.attackDuration2;
                                if (responsibilityForResponsesCough.isOn)
                                {
                                    MiddleManager.dateCough = System.DateTime.UtcNow.ToLocalTime().ToString("M/d/yy");
                                    for (int i = 0; i < screen.Length; i++)
                                    {
                                        screen[i].SetActive(false);
                                    }
                                    screen[7].SetActive(true);
                                    MiddleManager.savecorrect2 = 1;
                                }
                                else
                                {
                                    Error2.text = "Debe responsabilizarse de sus respuestas.";
                                }
                            }
                            else
                            {
                                Error2.text = "Debe seleccionar con que frecuencia y su duración.";
                            }
                        }
                        else if (noCoughWithPhlegm.isOn)
                        {
                            MiddleManager.coughwithphlegm = 0;
                            MiddleManager.frequency = 4;
                            MiddleManager.attackDuration = 4;
                            if (responsibilityForResponsesCough.isOn)
                            {
                                MiddleManager.dateCough = System.DateTime.UtcNow.ToLocalTime().ToString("M/d/yy");
                                for (int i = 0; i < screen.Length; i++)
                                {
                                    screen[i].SetActive(false);
                                }
                                screen[7].SetActive(true);
                                MiddleManager.savecorrect2 = 1;
                            }
                            else
                            {
                                Error2.text = "Debe responsabilizarse de sus respuestas.";
                            }
                        }
                        else
                        {
                            Error2.text = "Debe seleccionar si tiene o no tos con flema.";
                        }
                    }
                    else
                    {
                        Error2.text = "Debe seleccionar con que frecuencia.";
                    }
                }
                else if (noDryCough.isOn)
                {
                    MiddleManager.dryCough = 0;
                    MiddleManager.frequencyDryCough = 4;
                    if (yesCoughWithPhlegm.isOn)
                    {
                        MiddleManager.coughwithphlegm = 1;
                        if (MiddleManager.frequency2 != 0 && MiddleManager.attackDuration2 != 0)
                        {
                            MiddleManager.frequency = MiddleManager.frequency2;
                            MiddleManager.attackDuration = MiddleManager.attackDuration2;
                            if (responsibilityForResponsesCough.isOn)
                            {
                                MiddleManager.dateCough = System.DateTime.UtcNow.ToLocalTime().ToString("M/d/yy");
                                for (int i = 0; i < screen.Length; i++)
                                {
                                    screen[i].SetActive(false);
                                }
                                screen[7].SetActive(true);
                                MiddleManager.savecorrect2 = 1;
                            }
                            else
                            {
                                Error2.text = "Debe responsabilizarse de sus respuestas.";
                            }
                        }
                        else
                        {
                            Error2.text = "Debe seleccionar con que frecuencia y su duración.";
                        }
                    }
                    else if (noCoughWithPhlegm.isOn)
                    {
                        MiddleManager.coughwithphlegm = 0;
                        MiddleManager.frequency = 4;
                        MiddleManager.attackDuration = 4;
                        if (responsibilityForResponsesCough.isOn)
                        {
                            MiddleManager.dateCough = System.DateTime.UtcNow.ToLocalTime().ToString("M/d/yy");
                            for (int i = 0; i < screen.Length; i++)
                            {
                                screen[i].SetActive(false);
                            }
                            screen[7].SetActive(true);
                            MiddleManager.savecorrect2 = 1;
                        }
                        else
                        {
                            Error2.text = "Debe responsabilizarse de sus respuestas.";
                        }
                    }
                    else
                    {
                        Error2.text = "Debe seleccionar si tiene o no tos con flema.";
                    }
                }
                else
                {
                    Error2.text = "Debe seleccionar si tiene o no tos seca.";
                }
                
            }
            else
            {
                Error2.text = "Debes llenar los campos pedidos.";
            }
        }
        else
        {
            Error2.text = "No puede registrar sintomas de tos dos veces en un mismo día.";
        }
    }

    public void CleaningCough()
    {
        yesSoreThroat.isOn = false;
        noSoreThroat.isOn = false;
        yesDryCough.isOn = false;
        noDryCough.isOn = false;
        yesCoughWithPhlegm.isOn = false;
        noCoughWithPhlegm.isOn = false;
        responsibilityForResponsesCough.isOn = false;
        Error2.text = "";
        MiddleManager.throatPain = 2;
        MiddleManager.dryCough = 2;
        MiddleManager.coughwithphlegm = 4;
        MiddleManager.savecorrect2 = 0;
    }

    public void YesSoreThroat()
    {
        if (yesSoreThroat.isOn)
        {
            noSoreThroat.isOn = false;
        }
    }

    public void NoSoreThroat()
    {
        if (noSoreThroat.isOn)
        {
            yesSoreThroat.isOn = false;
        }
    }

    public void YesDryCough()
    {
        if (yesDryCough.isOn)
        {
            noDryCough.isOn = false;
        }
    }

    public void NoDryCough()
    {
        if (noDryCough.isOn)
        {
            yesDryCough.isOn = false;
        }
    }

    public void Frequency()
    {
        frequency.interactable = yesDryCough.isOn;
    }
    
    public void YesCoughWithPhlegm()
    {
        if (yesCoughWithPhlegm.isOn)
        {
            noCoughWithPhlegm.isOn = false;
        }
    }

    public void NoCoughWithPhlegm()
    {
        if (noCoughWithPhlegm.isOn)
        {
            yesCoughWithPhlegm.isOn = false;
        }
    }

    public void Frequency2()
    {
        frequency2.interactable = yesCoughWithPhlegm.isOn;
    }

    public void DurationAttacks()
    {
        durationAttacks.interactable = yesCoughWithPhlegm.isOn;
    }

    public void HeartRateRegistry()
    {
        for (int i = 0; i < screen.Length; i++)
        {
            screen[i].SetActive(false);
        }
        screen[10].SetActive(true);
    }

    public void HeartRateRegistryDaily()
    {
        if (MiddleManager.dateHeartRate != System.DateTime.UtcNow.ToLocalTime().ToString("M/d/yy"))
        {
            if (yesInfant.isOn)
            {
                MiddleManager.infant = 1;
                MiddleManager.beatsPerMinuteLactating = beatsPerMinuteLactating.text;
                if (responsibilityForResponsesHeart.isOn)
                {
                    MiddleManager.dateHeartRate = System.DateTime.UtcNow.ToLocalTime().ToString("M/d/yy");
                    for (int i = 0; i < screen.Length; i++)
                    {
                        screen[i].SetActive(false);
                    }
                    screen[7].SetActive(true);
                    MiddleManager.savecorrect3 = 1;
                }
                else
                {
                    Error3.text = "Debe responsabilizarse de sus respuestas.";
                }
            }
            else if (noInfant.isOn)
            {
                MiddleManager.infant = 0;
                MiddleManager.beatsPerMinute = beatsPerMinute.text;
                if (responsibilityForResponsesHeart.isOn)
                {
                    MiddleManager.dateHeartRate = System.DateTime.UtcNow.ToLocalTime().ToString("M/d/yy");
                    for (int i = 0; i < screen.Length; i++)
                    {
                        screen[i].SetActive(false);
                    }
                    screen[7].SetActive(true);
                    MiddleManager.savecorrect3 = 1;
                }
                else
                {
                    Error3.text = "Debe responsabilizarse de sus respuestas.";
                }
            }
            else
            {
                Error3.text = "Debe seleccionar si es lactante o no.";
            }
        }
        else
        {
            Error3.text = "No puede registrar sintomas de frecuencoa cardiaca dos veces en un mismo día.";
        }        
    }

    public void CleaningHeartRate()
    {
        yesInfant.isOn = false;
        noInfant.isOn = false;
        beatsPerMinute.text = "";
        beatsPerMinuteLactating.text = "";
        responsibilityForResponsesHeart.isOn = false;
        Error3.text = "";
        MiddleManager.savecorrect3 = 0;
        MiddleManager.beatsPerMinute = "0";
        MiddleManager.beatsPerMinuteLactating = "0";
        MiddleManager.infant = 2;
        MiddleManager.dateHeartRate = "0";
    }

    public void YesInfant()
    {
        if(yesInfant.isOn)
        {
            noInfant.isOn = false;
            beatsPerMinute.text = "";
        }
        beatsPerMinuteLactating.interactable = yesInfant.isOn;
    }

    public void NoInfant()
    {
        if(noInfant.isOn)
        {
            yesInfant.isOn = false;
            beatsPerMinuteLactating.text = "";
        }
        beatsPerMinute.interactable = noInfant.isOn;
    }

    public void OtherSymptomsRegistry()
    {
        for (int i = 0; i < screen.Length; i++)
        {
            screen[i].SetActive(false);
        }
        screen[11].SetActive(true);
    }

    public void OtherSymptomsRegistryDaily()
    {
        if (MiddleManager.dateOtherSymptoms != System.DateTime.UtcNow.ToLocalTime().ToString("M/d/yy"))
        {
            if (yesDifficultyBreathing.isOn)
            {
                if (MiddleManager.typeOfDyspnea2 != 0 && MiddleManager.evolution2 != 0)
                {
                    MiddleManager.typeOfDyspnea = MiddleManager.typeOfDyspnea2;
                    MiddleManager.evolution = MiddleManager.evolution2;
                    if ((yesfatigue.isOn || nofatigue.isOn) && (yesCongestionOrRunnyNose.isOn || noCongestionOrRunnyNose.isOn))
                    {
                        if (yesfatigue.isOn)
                        {
                            MiddleManager.fatigue = 1;
                        }

                        if (nofatigue.isOn)
                        {
                            MiddleManager.fatigue = 0;
                        }

                        if (yesCongestionOrRunnyNose.isOn)
                        {
                            MiddleManager.CongestionOrRunnyNose = 1;
                        }

                        if (noCongestionOrRunnyNose.isOn)
                        {
                            MiddleManager.CongestionOrRunnyNose = 0;
                        }

                        if (yesPulseOximeter.isOn)
                        {
                            MiddleManager.pulseOximeter = 1;
                            if (pulseOximeter.text != "")
                            {
                                MiddleManager.numberPulseOximeter = pulseOximeter.text;
                                if (responsibilityForResponsesOtherSymtoms.isOn)
                                {
                                    MiddleManager.dateOtherSymptoms = System.DateTime.UtcNow.ToLocalTime().ToString("M/d/yy");
                                    for (int i = 0; i < screen.Length; i++)
                                    {
                                        screen[i].SetActive(false);
                                    }
                                    screen[7].SetActive(true);
                                    MiddleManager.savecorrect4 = 1;
                                }
                                else
                                {
                                    Error4.text = "No puede registrar sintomas de tos dos veces en un mismo día.";
                                }
                            }
                            else
                            {
                                Error4.text = "Debe registrar el valor del pulsioxímetro.";
                            }
                        }
                        else if (noPulseOximeter.isOn)
                        {
                            MiddleManager.pulseOximeter = 0;
                            if (responsibilityForResponsesOtherSymtoms.isOn)
                            {
                                MiddleManager.dateOtherSymptoms = System.DateTime.UtcNow.ToLocalTime().ToString("M/d/yy");
                                for (int i = 0; i < screen.Length; i++)
                                {
                                    screen[i].SetActive(false);
                                }
                                screen[7].SetActive(true);
                                MiddleManager.savecorrect4 = 1;
                            }
                            else
                            {
                                Error4.text = "No puede registrar sintomas de tos dos veces en un mismo día.";
                            }
                        }
                        else
                        {
                            Error4.text = "Seleccionar si posee o no un pulsioxímetro";
                        }

                    }
                    else
                    {
                        Error4.text = "Debe selecionar si ha o no tenido fatiga y secreción nasal.";
                    }

                }
                else
                {
                    Error4.text = "Debes seleccionar el tipo de disnea y su evolución.";
                }
            }
            else if (noDifficultyBreathing.isOn)
            {
                if ((yesfatigue.isOn || nofatigue.isOn) && (yesCongestionOrRunnyNose.isOn || noCongestionOrRunnyNose.isOn))
                {
                    if (yesfatigue.isOn)
                    {
                        MiddleManager.fatigue = 1;
                    }

                    if (nofatigue.isOn)
                    {
                        MiddleManager.fatigue = 0;
                    }

                    if (yesCongestionOrRunnyNose.isOn)
                    {
                        MiddleManager.CongestionOrRunnyNose = 1;
                    }

                    if (noCongestionOrRunnyNose.isOn)
                    {
                        MiddleManager.CongestionOrRunnyNose = 0;
                    }

                    if (yesPulseOximeter.isOn)
                    {
                        MiddleManager.pulseOximeter = 1;
                        if (pulseOximeter.text != "")
                        {
                            MiddleManager.numberPulseOximeter = pulseOximeter.text;
                            if (responsibilityForResponsesOtherSymtoms.isOn)
                            {
                                MiddleManager.dateOtherSymptoms = System.DateTime.UtcNow.ToLocalTime().ToString("M/d/yy");
                                for (int i = 0; i < screen.Length; i++)
                                {
                                    screen[i].SetActive(false);
                                }
                                screen[7].SetActive(true);
                                MiddleManager.savecorrect4 = 1;
                            }
                            else
                            {
                                Error4.text = "No puede registrar sintomas de tos dos veces en un mismo día.";
                            }
                        }
                        else
                        {
                            Error4.text = "Debe registrar el valor del pulsioxímetro.";
                        }
                    }
                    else if (noPulseOximeter.isOn)
                    {
                        MiddleManager.pulseOximeter = 0;
                        if (responsibilityForResponsesOtherSymtoms.isOn)
                        {
                            MiddleManager.dateOtherSymptoms = System.DateTime.UtcNow.ToLocalTime().ToString("M/d/yy");
                            for (int i = 0; i < screen.Length; i++)
                            {
                                screen[i].SetActive(false);
                            }
                            screen[7].SetActive(true);
                            MiddleManager.savecorrect4 = 1;
                        }
                        else
                        {
                            Error4.text = "No puede registrar sintomas de tos dos veces en un mismo día.";
                        }
                    }
                    else
                    {
                        Error4.text = "Seleccionar si posee o no un pulsioxímetro";
                    }

                }
                else
                {
                    Error4.text = "Debe selecionar si ha o no tenido fatiga y secreción nasal.";
                }
            }
            else
            {
                Error4.text = "Debe seleccionar si ha tenido dificultad para respirar o no.";
            }
        }
        else
        {
            Error4.text = "No puede registrar otros simtomas dos veces en un mismo día.";
        }        
    }

    public void CleaningOtherSymptoms()
    {
        yesDifficultyBreathing.isOn = false;
        noDifficultyBreathing.isOn = false;
        yesfatigue.isOn = false;
        nofatigue.isOn = false;
        yesCongestionOrRunnyNose.isOn = false;
        noCongestionOrRunnyNose.isOn = false;
        yesPulseOximeter.isOn = false;
        noPulseOximeter.isOn = false;
        pulseOximeter.text = "";
        responsibilityForResponsesOtherSymtoms.isOn = false;
        Error4.text = "";
        MiddleManager.savecorrect4 = 0;
        MiddleManager.typeOfDyspnea = 0;
        MiddleManager.evolution = 0;
        MiddleManager.fatigue = 2;
        MiddleManager.CongestionOrRunnyNose = 2;
    }

    public void YesDifficultyBreathing()
    {
        if (yesDifficultyBreathing.isOn)
        {
            noDifficultyBreathing.isOn = false;
        }
        typeOfDyspnea.interactable = yesDifficultyBreathing.isOn;
        evolution.interactable = yesDifficultyBreathing.isOn;
    }

    public void NoDifficultyBreathing()
    {
        if (noDifficultyBreathing.isOn)
        {
            yesDifficultyBreathing.isOn = false;
        }
    }

    public void YesFatigue()
    {
        if (yesfatigue.isOn)
        {
            nofatigue.isOn = false;
        }
    }

    public void NoFatigue()
    {
        if (nofatigue.isOn)
        {
            yesfatigue.isOn = false;
        }
    }

    public void YesCongestionOrRunnyNose()
    {
        if (yesCongestionOrRunnyNose.isOn)
        {
            noCongestionOrRunnyNose.isOn = false;
        }
    }

    public void NoCongestionOrRunnyNose()
    {
        if (noCongestionOrRunnyNose.isOn)
        {
            yesCongestionOrRunnyNose.isOn = false;
        }
    }

    public void YesPulseOximeter()
    {
        if(yesPulseOximeter.isOn)
        {
            noPulseOximeter.isOn = false;
        }
        pulseOximeter.interactable = yesPulseOximeter.isOn;
    }

    public void NoPulseOximeter()
    {
        if (noPulseOximeter.isOn)
        {
            yesPulseOximeter.isOn = false;
            pulseOximeter.text = "";
        }
        
    }

    public void GraphicAnalysisMenu()
    {
        for (int i = 0; i < screen.Length; i++)
        {
            screen[i].SetActive(false);
        }
        screen[12].SetActive(true);
    }

    public void TodaysDataGraphic()
    {
        for (int i = 0; i < screen.Length; i++)
        {
            screen[i].SetActive(false);
        }
        screen[13].SetActive(true);
    }

    public void WeeklyGraphic()
    {
        for (int i = 0; i < screen.Length; i++)
        {
            screen[i].SetActive(false);
        }
        screen[14].SetActive(true);
    }

    public void MonthlyGraphic()
    {
        for (int i = 0; i < screen.Length; i++)
        {
            screen[i].SetActive(false);
        }
        screen[15].SetActive(true);
    }

    public void MotivateYourselfInTheProcess()
    {
        SceneManager.LoadScene(1);
    }

    public void Setting()
    {
        for (int i = 0; i < screen.Length; i++)
        {
            screen[i].SetActive(false);
        }
        screen[16].SetActive(true);
    }

    public void Exit()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void Cleaning()
    {
        nameText.text = "";
        fullNameText.text = "";
        emailText.text = "";
        cellPhoneText.text = "";
        birthdateText.text = "";
    }
}