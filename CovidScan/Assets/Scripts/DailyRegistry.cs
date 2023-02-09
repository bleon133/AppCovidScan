using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DailyRegistry : MonoBehaviour
{
    int verification;
    int verification2;
    int verification3;

    public void VerificationFeverDailyRegister()
    {
        StartCoroutine(VerificationFeverRegister());
    }

    IEnumerator VerificationFeverRegister()
    {
        WWWForm form2 = new WWWForm();
        form2.AddField("dateToday", MiddleManager.dateToday);
        form2.AddField("identificationCardPat", MiddleManager.identificationCard);
        Debug.Log(MiddleManager.identificationCard);
        WWW www2 = new WWW("http://localhost/CovidScanMySQL/verificationfeverregistry.php", form2);
        yield return www2;
        if (www2.text == "Existing record")
        {
            MiddleManager.dateFever = MiddleManager.dateToday;
            Debug.Log("Ingreso Incorrecto" + www2.text);
            verification = 0;
            Debug.Log(verification);
        }
        else
        {
            verification = 1;
            MiddleManager.dateFever = "";
            Debug.Log(www2.text);
        }
    }

    public void VerificationCoughPeriodicityDailyRegister()
    {
        StartCoroutine(VerificationCoughPeriodicityRegister());
    }

    IEnumerator VerificationCoughPeriodicityRegister()
    {
        WWWForm form4 = new WWWForm();
        form4.AddField("dateToday", MiddleManager.dateToday);
        form4.AddField("identificationCardPat", MiddleManager.identificationCard);
        Debug.Log(MiddleManager.identificationCard);
        WWW www4 = new WWW("http://localhost/CovidScanMySQL/verificationcoughregistry.php", form4);
        yield return www4;
        if (www4.text == "Existing record")
        {
            MiddleManager.dateCough = MiddleManager.dateToday;
            Debug.Log("Ingreso Incorrecto" + www4.text);
            verification2 = 0;
            Debug.Log(verification2);
        }
        else
        {
            verification2 = 1;
            MiddleManager.dateCough = "";
            Debug.Log(www4.text);
            Debug.Log(verification2);
        }
    }

    public void VerificationHeartRateDailyRegistry()
    {
        StartCoroutine(VerificationHeartRateRegistry());
    }

    IEnumerator VerificationHeartRateRegistry()
    {
        WWWForm form6 = new WWWForm();
        form6.AddField("dateToday", MiddleManager.dateToday);
        form6.AddField("identificationCardPat", MiddleManager.identificationCard);
        Debug.Log(MiddleManager.identificationCard);
        WWW www6 = new WWW("http://localhost/CovidScanMySQL/verificationheartrateregistry.php", form6);
        yield return www6;
        if (www6.text == "Existing record")
        {
            MiddleManager.dateHeartRate = MiddleManager.dateToday;
            Debug.Log("Ingreso Incorrecto" + www6.text);
            verification3 = 0;
            Debug.Log(verification3);
        }
        else
        {
            verification3 = 1;
            MiddleManager.dateCough = "";
            Debug.Log(www6.text);
            Debug.Log(verification3);
        }
    }

    public void FeverDailyRegister()
    {
        StartCoroutine(FeverRegister());
    }

    IEnumerator FeverRegister()
    {
        if(verification == 1 && MiddleManager.savecorrect == 1)
        {
            WWWForm form = new WWWForm();
            form.AddField("over37Degrees", MiddleManager.numberYesOrNoHigherTemperature);
            form.AddField("constantOrIntermittent", MiddleManager.numberconstantOrIntermittent);
            form.AddField("temperatureNumber", MiddleManager.numbertypedTemperature);
            form.AddField("dateFever", MiddleManager.dateFever);
            form.AddField("identificationCardPat", MiddleManager.identificationCard);

            WWW www = new WWW("http://localhost/CovidScanMySQL/feverregistry.php", form);
            yield return www;
        }
    }

    public void CoughPeriodicityDailyRegister()
    {
        StartCoroutine(CoughPeriodicityRegister());
    }

    IEnumerator CoughPeriodicityRegister()
    {
        if (verification2 == 1 && MiddleManager.savecorrect2 == 1)
        {
            WWWForm form3 = new WWWForm();
            form3.AddField("soreThroatFor3Days", MiddleManager.throatPain);
            form3.AddField("dryCough", MiddleManager.dryCough);
            form3.AddField("frequencyOfDryCough", MiddleManager.frequencyDryCough);
            form3.AddField("coughWithPhlegm", MiddleManager.coughwithphlegm);
            form3.AddField("frequencyOfCoughWithPhlegm", MiddleManager.frequency);
            form3.AddField("durationOfAttacks", MiddleManager.attackDuration);
            form3.AddField("dateCough", MiddleManager.dateCough);
            form3.AddField("identificationCardPat", MiddleManager.identificationCard);

            WWW www3 = new WWW("http://localhost/CovidScanMySQL/coughregistry.php", form3);
            yield return www3;
        }
    }

    public void HeartRateDailyRegister()
    {
        StartCoroutine(HeartRateRegister());
    }

    IEnumerator HeartRateRegister()
    {
        if (verification3 == 1 && MiddleManager.savecorrect3 == 1)
        {
            WWWForm form5 = new WWWForm();
            form5.AddField("infant", MiddleManager.infant);
            form5.AddField("beatsPerMinute", MiddleManager.beatsPerMinute);
            form5.AddField("beatsPerMinuteInfant", MiddleManager.beatsPerMinuteLactating);
            form5.AddField("dateHeart", MiddleManager.dateHeartRate);
            form5.AddField("identificationCardPat", MiddleManager.identificationCard);

            WWW www5 = new WWW("http://localhost/CovidScanMySQL/heartrateregistry.php", form5);
            yield return www5;
        }
    }
}