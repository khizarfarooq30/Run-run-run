using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour
{
    public static AdManager Instance { get { return instance; } }
    private static AdManager instance;

    [SerializeField] private string gameID;
    [SerializeField] private string rewardedVideoPlacementId;
    [SerializeField] private bool testMode;

}
