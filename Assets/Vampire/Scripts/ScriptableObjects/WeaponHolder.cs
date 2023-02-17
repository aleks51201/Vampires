using UnityEngine;
using Vampire.Data;

namespace Vampire.ScriptableObjects
{
    [CreateAssetMenu(fileName = "WeaponDataHolder", menuName = "Config/Holder/Weapon Data Holder")]
    public class WeaponHolder:ScriptableObject
    {
        [SerializeField] private GradeData<WeaponData>[] weaponData;
    }
}
