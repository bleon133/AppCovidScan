using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Login : MonoBehaviour
{
    public InputField emailLoginInput;
    public InputField passwordLogin;
    public Button loginButton;
    public Text errorText;

    public void CallLogin()
    {
        StartCoroutine(LoginUser());
    }

    IEnumerator LoginUser()
    {
        WWWForm form1 = new WWWForm();
        form1.AddField("email", emailLoginInput.text);
        form1.AddField("password", passwordLogin.text);
        WWW www = new WWW("http://localhost/CovidScanMySQL/loginuser.php", form1);
        yield return www;
        if (www.text[0] == '0')
        {
            MiddleManager.email = emailLoginInput.text;
            MiddleManager.names = www.text.Split('\t')[1];
        }
        else
        {
            errorText.text = www.text;
        }

        WWWForm form2 = new WWWForm();
        form2.AddField("email", emailLoginInput.text);
        form2.AddField("password", passwordLogin.text);
        WWW www2 = new WWW("http://localhost/CovidScanMySQL/loginuser2.php", form2);
        yield return www2;
        if (www2.text[0] == '0')
        {
            MiddleManager.lastNames = www2.text.Split('\t')[1];
        }
        else
        {
            Debug.Log("User Login failed. Error #" + www2.text);
        }

        WWWForm form3 = new WWWForm();
        form3.AddField("email", emailLoginInput.text);
        form3.AddField("password", passwordLogin.text);
        WWW www3 = new WWW("http://localhost/CovidScanMySQL/loginuser3.php", form3);
        yield return www3;
        if (www3.text[0] == '0')
        {

            MiddleManager.cellPhone = www3.text.Split('\t')[1];
        }
        else
        {
            Debug.Log("User Login failed. Error #" + www3.text);
        }

        WWWForm form4 = new WWWForm();
        form4.AddField("email", emailLoginInput.text);
        form4.AddField("password", passwordLogin.text);
        WWW www4 = new WWW("http://localhost/CovidScanMySQL/loginuser4.php", form4);
        yield return www4;
        if (www4.text[0] == '0')
        {
            MiddleManager.birthdate = www4.text.Split('\t')[1];
        }
        else
        {
            Debug.Log("User Login failed. Error #" + www4.text);
        }

        WWWForm form5 = new WWWForm();
        form5.AddField("email", emailLoginInput.text);
        form5.AddField("password", passwordLogin.text);
        WWW www5 = new WWW("http://localhost/CovidScanMySQL/loginuser5.php", form5);
        yield return www5;
        if (www5.text[0] == '0')
        {
            MiddleManager.avatar = Convert.ToInt32(www5.text.Split('\t')[1]);
        }
        else
        {
            Debug.Log("User Login failed. Error #" + www5.text);
        }

        WWWForm form6 = new WWWForm();
        form6.AddField("email", emailLoginInput.text);
        form6.AddField("password", passwordLogin.text);
        WWW www6 = new WWW("http://localhost/CovidScanMySQL/loginuser6.php", form6);
        yield return www6;
        if (www6.text[0] == '0')
        {
            MiddleManager.identificationCard = www6.text.Split('\t')[1];
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        }
        else
        {
            Debug.Log("User Login failed. Error #" + www6.text);
        }

    }

    

    public void VerifyInputs()
    {
        loginButton.interactable = (emailLoginInput.text.Length >= 6 && passwordLogin.text.Length >= 6);
    }
}
