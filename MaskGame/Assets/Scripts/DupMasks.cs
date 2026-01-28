using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DupMasks : MonoBehaviour
{
    MasterMask MasterMaskScript;

    public TextMeshProUGUI EyesText;
    public TextMeshProUGUI NoseText;
    public TextMeshProUGUI MouthText;

    void Start()
    {
        MasterMaskScript = GameObject.Find("Master Mask").GetComponent<MasterMask>();
    }
    
    public void SetFeatures()
    {
        EyesText.text = MasterMaskScript.PickedEyes;
        NoseText.text = MasterMaskScript.PickedNose;
        MouthText.text = MasterMaskScript.PickedMouth;
        this.GetComponent<Image>().color = MasterMaskScript.PickedColour;
    }
}
