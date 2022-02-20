using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "ScriptableObjects/ResourceTypeList")]
public class ResourceTypeListSO : ScriptableObject
{
    // Start is called before the first frame update
    public List<ResourceTypeSO> list;
}
