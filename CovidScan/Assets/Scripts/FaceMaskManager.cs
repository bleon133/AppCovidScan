using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;
public class FaceMaskManager : MonoBehaviour
{
    private List<AugmentedFace> _tempAugmentedFaces = new List<AugmentedFace>();
    public GameObject faceMask;

    // Update is called once per frame
    void Update()
    {
        Session.GetTrackables<AugmentedFace>(_tempAugmentedFaces);

        if(_tempAugmentedFaces.Count == 0)
        {
            faceMask.SetActive(false);
        }
        else
        {
            faceMask.SetActive(true);
        }
    }
}
