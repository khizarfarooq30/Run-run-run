using System;
using UnityEngine;

public class DeathState : BaseState
{
    [SerializeField] private Vector3 knockbackForce = new Vector3(0, 4, -3);
    private Vector3 currentKockback;

    public Animator policeAnimator;

    private void Start()
    {
        AdmobScript.instance.requestInterstital();
    }

    public override void Construct()
    {
        motor.anim?.SetTrigger("Death");
        policeAnimator.SetTrigger("Intercepting");
        currentKockback = knockbackForce;
        AdmobScript.instance.ShowInterstitialAd();
    }

    public override Vector3 ProcessMotion()
    {
        Vector3 m = currentKockback;

        currentKockback = new Vector3(
            0,
            currentKockback.y -= motor.gravity * Time.deltaTime,
            currentKockback.z += 2.0f * Time.deltaTime);

        if (currentKockback.z > 0)
        {
            currentKockback.z = 0;
            GameManager.Instance.ChangeState(GameManager.Instance.GetComponent<GameStateDeath>());
        }

        return currentKockback;
    }
}
