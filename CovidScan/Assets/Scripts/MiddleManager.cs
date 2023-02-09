using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MiddleManager : MonoBehaviour
{
    public static string email;
    public static string names;
    public static string lastNames;
    public static string cellPhone;
    public static string birthdate;
    public static int error1;
    public static string error2;
    public static int avatar;
    public static string identificationCard;

    //Pathology
    public static int numberPositiveCovid19;
    public static int numberPossiblyCovid19;
    public static int numberCancer;
    public static int numberMellitusDiabetes;
    public static int numberUncompensatedThyroid;
    public static int numberBadNutrition;
    public static int numberKidneyOrLiver;
    public static int numberRespiratorySystem;
    public static int numberInmuneSystem;
    public static int numberCardiovascularSystem;
    public static int numberRheumatoid;
    public static int numberOrganTransplant;
    public static int numberVihOrSida;
    public static int numberUseCorticosteroids;
    public static int numberPregnancy;

    //Fever
    public static string dateToday = System.DateTime.UtcNow.ToLocalTime().ToString("M/d/yy");
    public static int numberYesOrNoHigherTemperature;
    public static int numberconstantOrIntermittent;
    public static string dateFever;
    public static string numbertypedTemperature;
    public static int savecorrect;

    //Cough Periodicity
    public static string dateCough;
    public static int throatPain;
    public static int dryCough;
    public static int frequencyDryCough;
    public static int frequencyDryCough2;
    public static int coughwithphlegm;
    public static int frequency;
    public static int frequency2;
    public static int attackDuration;
    public static int attackDuration2;
    public static int savecorrect2;

    //Heart Rate
    public static int infant;
    public static string beatsPerMinute;
    public static string beatsPerMinuteLactating;
    public static string dateHeartRate;
    public static int savecorrect3;

    //Other Symptoms
    public static int typeOfDyspnea;
    public static int typeOfDyspnea2;
    public static int evolution;
    public static int evolution2;
    public static int fatigue;
    public static int CongestionOrRunnyNose;
    public static int pulseOximeter;
    public static string numberPulseOximeter;
    public static string dateOtherSymptoms;
    public static int savecorrect4;


    public static bool LoggedIn { get { return email != null; } }

    public static void LogOut()
    {
        email = null;
    }
}
