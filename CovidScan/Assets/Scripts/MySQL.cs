using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MySQL : MonoBehaviour
{
    string newPatientEmail;
    string passwordPatient;
    string identificationCardPatient;
    int identificationTypePatient;
    string cellPhonePatient;
    int ipsNumberPatient;
    int epsNumberPatient;
    string namesPatient;
    string lastNamesPatient;
    string agePatient;
    string addressPatient;
    int locationNumberPatient;
    int avatarPatient;
    int error;
    string error2;
    int numberRecoveredFromCovid19;

    //connections between scripts
    public Funciones principalScript;
    public CalendarController calendarScript;

    public void VerificationRegister()
    {
        StartCoroutine(verification());
    }

    IEnumerator verification()
    {
        newPatientEmail = principalScript.emailRegistryInput.text;
        Debug.Log(newPatientEmail);

        WWWForm form2 = new WWWForm();
        form2.AddField("email", newPatientEmail); //Insertando Usuario y la contraseña de la base de datos

        WWW www2 = new WWW("http://localhost/CovidScanMySQL/verification.php", form2); //Asignando el driver de conexión
        yield return www2; //Lo que se demore la pagina de encontrar es lo que demora en continuar
        if (www2.text == "El correo ya existe.")
        {
            error = 0;
            Debug.Log("El correo ya existe.");
        }
        else if (www2.text == "")
        {
            error = 1;
            Debug.Log("Correo Correcto");
        }
    }

    public void IdentificationVerificationRegister()
    {
        StartCoroutine(identificationVerification());
    }

    IEnumerator identificationVerification()
    {
        identificationCardPatient = principalScript.identificationCardInput.text;

        WWWForm form3 = new WWWForm();
        form3.AddField("identificationCard", identificationCardPatient); //Insertando Usuario y la contraseña de la base de datos

        WWW www3 = new WWW("http://localhost/CovidScanMySQL/identificationverification.php", form3); //Asignando el driver de conexión
        yield return www3; //Lo que se demore la pagina de encontrar es lo que demora en continuar
        if (www3.text == "El documento ya existe.")
        {
            error2 = "El documento ya existe.";
            Debug.Log("La identificación ya existe.");
        }
        else if (www3.text == "")
        {
            error2 = "";
            Debug.Log("Identificación Correcta");
        }
    }

    void Update()
    {
        MiddleManager.error1 = error;
        MiddleManager.error2 = error2;
    }

    public void CallRegister()
    {
        StartCoroutine(Register());
    }

    IEnumerator Register()
    {
        newPatientEmail = principalScript.emailRegistryInput.text;
        passwordPatient = principalScript.passwordRegister.text;
        identificationCardPatient = principalScript.identificationCardInput.text;
        identificationTypePatient = principalScript.identificationType;
        cellPhonePatient = principalScript.cellPhoneInput.text;
        ipsNumberPatient = principalScript.numberIps;
        epsNumberPatient = principalScript.numberEps;
        namesPatient = principalScript.namesInput.text;
        lastNamesPatient = principalScript.lastNamesInput.text;
        agePatient = calendarScript.birthday;
        addressPatient = principalScript.addressInput.text;
        locationNumberPatient = principalScript.numberlocation;
        avatarPatient = principalScript.numberAvatar;
        numberRecoveredFromCovid19 = 0;

        WWWForm form = new WWWForm();
        form.AddField("email", newPatientEmail); //Insertando Usuario y la contraseña de la base de datos
        form.AddField("password", passwordPatient); //Insertando Usuario y la contraseña de la base de datos
        form.AddField("names", namesPatient);
        form.AddField("lastName", lastNamesPatient);
        form.AddField("cellPhoneLong", cellPhonePatient);
        form.AddField("birthdate", agePatient);
        form.AddField("identificationCard", identificationCardPatient);
        form.AddField("identificationType", identificationTypePatient);
        form.AddField("address", addressPatient);
        form.AddField("location", locationNumberPatient);
        form.AddField("eps", epsNumberPatient);
        form.AddField("ips", ipsNumberPatient);
        form.AddField("avatar", avatarPatient);
        
        form.AddField("positiveCovid19", MiddleManager.numberPositiveCovid19);
        form.AddField("possiblyCovid19", MiddleManager.numberPossiblyCovid19);
        form.AddField("recoveredFromCovid19", numberRecoveredFromCovid19);
        form.AddField("cancer", MiddleManager.numberCancer);
        form.AddField("mellitusDiabetes", MiddleManager.numberMellitusDiabetes);
        form.AddField("uncompensatedThyroid", MiddleManager.numberUncompensatedThyroid);
        form.AddField("badNutrition", MiddleManager.numberBadNutrition);
        form.AddField("kidneyOrLiver", MiddleManager.numberKidneyOrLiver);
        form.AddField("respiratorySystem", MiddleManager.numberRespiratorySystem);
        form.AddField("inmuneSystem", MiddleManager.numberInmuneSystem);
        form.AddField("cardiovascularSystem", MiddleManager.numberCardiovascularSystem);
        form.AddField("rheumatoid", MiddleManager.numberRheumatoid);
        form.AddField("organTransplant", MiddleManager.numberOrganTransplant);
        form.AddField("vihOrSida", MiddleManager.numberVihOrSida);
        form.AddField("useCorticosteroids", MiddleManager.numberUseCorticosteroids);
        form.AddField("pregnancy", MiddleManager.numberPregnancy);
        form.AddField("identificationCardPat", identificationCardPatient);

        WWW www = new WWW("http://localhost/CovidScanMySQL/register.php", form); //Asignando el driver de conexión
        yield return www; //Lo que se demore la pagina de encontrar es lo que demora en continuar
        if (www.text == "0") //0 -> Se conecto
        {
            Debug.Log("User created successfully.");
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        else
        {
            Debug.Log("User creation failed. Error #" + www.text); // Creación fallida depediendo al número del error
        }
    }
}
