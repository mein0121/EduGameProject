using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowInfo : MonoBehaviour
{
    [SerializeField] GameObject infoUI;
    [SerializeField] GameObject stateInf;
    Texture2D statetexture;
    Texture2D flagtexture;
    [SerializeField] RawImage flag;
    [SerializeField] RawImage state;
    [SerializeField] GameObject button;
    private AudioSource theAudio;
    [SerializeField] AudioClip[] clips;
    private void Start()
    {
        theAudio = GetComponent<AudioSource>();
    }

    public void DisplayInfo(string stateName, int audioNum)
    {
        theAudio.clip = clips[audioNum];
        theAudio.Play();
        infoUI.SetActive(true);
        button.SetActive(true);
        stateInf.SetActive(false);
        switch (stateName)
        {
            case "CA":

                statetexture = Resources.Load("Images/stateImages/ca-largemap") as Texture2D;
                state.GetComponent<RawImage>().texture = statetexture;
                flagtexture = Resources.Load("Images/stateflagImages/ca-largeflag") as Texture2D;
                flag.GetComponent<RawImage>().texture = flagtexture;
                break;
            case "OR":
                statetexture = Resources.Load("Images/stateImages/or-largemap") as Texture2D;
                state.GetComponent<RawImage>().texture = statetexture;
                flagtexture = Resources.Load("Images/stateflagImages/or-largeflag") as Texture2D;
                flag.GetComponent<RawImage>().texture = flagtexture;
                break;
            case "NY":
                statetexture = Resources.Load("Images/stateImages/ny-largemap") as Texture2D;
                state.GetComponent<RawImage>().texture = statetexture;
                flagtexture = Resources.Load("Images/stateflagImages/ny-largeflag") as Texture2D;
                flag.GetComponent<RawImage>().texture = flagtexture;
                break;
            case "PA":
                statetexture = Resources.Load("Images/stateImages/pa-largemap") as Texture2D;
                state.GetComponent<RawImage>().texture = statetexture;
                flagtexture = Resources.Load("Images/stateflagImages/pa-largeflag") as Texture2D;
                flag.GetComponent<RawImage>().texture = flagtexture;
                break;
            case "FL":
                statetexture = Resources.Load("Images/stateImages/fl-largemap") as Texture2D;
                state.GetComponent<RawImage>().texture = statetexture;
                flagtexture = Resources.Load("Images/stateflagImages/fl-largeflag") as Texture2D;
                flag.GetComponent<RawImage>().texture = flagtexture;
                break;
            case "AL":
                statetexture = Resources.Load("Images/stateImages/al-largemap") as Texture2D;
                state.GetComponent<RawImage>().texture = statetexture;
                flagtexture = Resources.Load("Images/stateflagImages/al-largeflag") as Texture2D;
                flag.GetComponent<RawImage>().texture = flagtexture;
                break;
            case "KS":
                statetexture = Resources.Load("Images/stateImages/ks-largemap") as Texture2D;
                state.GetComponent<RawImage>().texture = statetexture;
                flagtexture = Resources.Load("Images/stateflagImages/ks-largeflag") as Texture2D;
                flag.GetComponent<RawImage>().texture = flagtexture;
                break;
            case "CO":
                statetexture = Resources.Load("Images/stateImages/co-largemap") as Texture2D;
                state.GetComponent<RawImage>().texture = statetexture;
                flagtexture = Resources.Load("Images/stateflagImages/co-largeflag") as Texture2D;
                flag.GetComponent<RawImage>().texture = flagtexture;
                break;
            case "WY":
                statetexture = Resources.Load("Images/stateImages/wy-largemap") as Texture2D;
                state.GetComponent<RawImage>().texture = statetexture;
                flagtexture = Resources.Load("Images/stateflagImages/wy-largeflag") as Texture2D;
                flag.GetComponent<RawImage>().texture = flagtexture;
                break;
            case "NE":
                statetexture = Resources.Load("Images/stateImages/ne-largemap") as Texture2D;
                state.GetComponent<RawImage>().texture = statetexture;
                flagtexture = Resources.Load("Images/stateflagImages/ne-largeflag") as Texture2D;
                flag.GetComponent<RawImage>().texture = flagtexture;
                break;
            case "ND":
                statetexture = Resources.Load("Images/stateImages/nd-largemap") as Texture2D;
                state.GetComponent<RawImage>().texture = statetexture;
                flagtexture = Resources.Load("Images/stateflagImages/nd-largeflag") as Texture2D;
                flag.GetComponent<RawImage>().texture = flagtexture;
                break;
            case "TX":
                statetexture = Resources.Load("Images/stateImages/tx-largemap") as Texture2D;
                state.GetComponent<RawImage>().texture = statetexture;
                flagtexture = Resources.Load("Images/stateflagImages/tx-largeflag") as Texture2D;
                flag.GetComponent<RawImage>().texture = flagtexture;
                break;
            case "AZ":
                statetexture = Resources.Load("Images/stateImages/az-largemap") as Texture2D;
                state.GetComponent<RawImage>().texture = statetexture;
                flagtexture = Resources.Load("Images/stateflagImages/az-largeflag") as Texture2D;
                flag.GetComponent<RawImage>().texture = flagtexture;
                break;
            case "IA":
                statetexture = Resources.Load("Images/stateImages/ia-largemap") as Texture2D;
                state.GetComponent<RawImage>().texture = statetexture;
                flagtexture = Resources.Load("Images/stateflagImages/ia-largeflag") as Texture2D;
                flag.GetComponent<RawImage>().texture = flagtexture;
                break;
            case "MD":
                statetexture = Resources.Load("Images/stateImages/md-largemap") as Texture2D;
                state.GetComponent<RawImage>().texture = statetexture;
                flagtexture = Resources.Load("Images/stateflagImages/md-largeflag") as Texture2D;
                flag.GetComponent<RawImage>().texture = flagtexture;
                break;

        }

    }

   

    public void BacktoFirst()
    {
        SceneManager.LoadScene(8);
    }
}
