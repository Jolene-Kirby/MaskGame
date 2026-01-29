using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DupMasks : MonoBehaviour
{
    MasterMask MasterMaskScript;
    GameplayManager GameplayManagerScript;


    public TextMeshProUGUI EyesText;
    public TextMeshProUGUI NoseText;
    public TextMeshProUGUI MouthText;

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameplayManagerScript = GameObject.Find("Game Stats").GetComponent<GameplayManager>();
            GameplayManagerScript.CorrectMask();
        }
    }
    
    public void SetFeatures()
    {
        MasterMaskScript = GameObject.Find("Master Mask").GetComponent<MasterMask>();
        EyesText.text = MasterMaskScript.PickedEyes;
        NoseText.text = MasterMaskScript.PickedNose;
        MouthText.text = MasterMaskScript.PickedMouth;
        this.GetComponent<Image>().color = MasterMaskScript.PickedColour;
    }
}
