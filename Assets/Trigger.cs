using System.Collections;
using UnityEngine;

public class Furnace : MonoBehaviour
{
    public float burnTime = 10f; // Time in seconds the furnace burns with each coal

    public float currentBurnTime = 0f;
    public bool isBurning = false;

    void Start()
    {
        currentBurnTime = 0f;
        isBurning = false;
    }

    // Function to start the furnace burning
    public void StartBurning()
    {
        if (!isBurning)
        {
            StartCoroutine(Burn());
        }
    }

    // Coroutine to handle the burning process
    IEnumerator Burn()
    {
    isBurning = true;
    while (currentBurnTime < burnTime)
    {
        currentBurnTime += Time.deltaTime;
        Debug.Log("Burning... Current Burn Time: " + currentBurnTime);
        yield return null;
    }
    // Fire has burned out
    isBurning = false;
    currentBurnTime = 0f;
    Debug.Log("Fire has burned out.");
    }
}
