using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    private float timer;
    private float timerMax;
    private BuildingTypeSO buildingType;

    private void Awake()
    {
        buildingType = GetComponent<BuildingTypeHolder>().buildingType;
        timerMax = buildingType.resourceGeneratorData.timerMax;
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer += timerMax;
            ResourceManager.Instance.AddResource(buildingType.resourceGeneratorData.resourceType, 2);
        }
    }
}
