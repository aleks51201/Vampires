using System.Collections.Generic;
using UnityEngine;
using Vampire.Data;

namespace Vampire.ScriptableObjects
{
    [CreateAssetMenu(fileName = "EnemyDataHolder", menuName = "Config/Holder/Enemy Data Holder")]
    public class EnemyHolder: ScriptableObject
    {
       [SerializeField] private EnemyData[] _enemyData;
    }
}

