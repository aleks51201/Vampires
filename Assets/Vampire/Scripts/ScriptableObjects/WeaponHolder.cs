using UnityEngine;
using Vampire.Data;

namespace Vampire.ScriptableObjects
{
    [CreateAssetMenu(fileName = "WeaponDataHolder", menuName = "Weapon Data Holder")]
    public class WeaponHolder:ScriptableObject
    {
        [SerializeField] private WeaponData[] weaponData;
    }
}
