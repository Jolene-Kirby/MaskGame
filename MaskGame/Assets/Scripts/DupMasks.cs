using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DupMasks : MonoBehaviour
{
    MasterMask MasterMaskScript;
    GameplayManager GameplayManagerScript;

    public Image EyesSprite;
    public Image NoseSprite;
    public Image MouthSprite;

    public float ShakeMagnitude;
    float ShakeMaxAngle;
    public float ShakeDuration;
    float ShakeTimer;
    bool Shaking;

    void OnEnable()
    {
        Shaking = false;
        ShakeTimer = 0;
    }

    void Update()
    {
        if (ShakeTimer > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, Random.Range(-ShakeMaxAngle, ShakeMaxAngle));

            ShakeTimer -= Time.deltaTime;
            ShakeMaxAngle *= (ShakeTimer/ShakeDuration);

        }
        else if (ShakeTimer <= 0 && Shaking == true)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            
            Shaking = false;
        }
    }

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameplayManagerScript = GameObject.Find("Game Stats").GetComponent<GameplayManager>();
            GameplayManagerScript.CorrectMaskStep1();

            ShakeTimer = ShakeDuration;
            ShakeMaxAngle = ShakeMagnitude;
            Shaking = true;
        }
    }
    
    public void SetFeatures()
    {
        MasterMaskScript = GameObject.Find("Master Mask").GetComponent<MasterMask>();
        EyesSprite.sprite = MasterMaskScript.PickedEyes;
        NoseSprite.sprite = MasterMaskScript.PickedNose;
        MouthSprite.sprite = MasterMaskScript.PickedMouth;
        GetComponent<Image>().color = MasterMaskScript.PickedColour;
    }
}
