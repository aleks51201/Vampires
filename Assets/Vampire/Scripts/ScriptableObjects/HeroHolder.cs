using System.Collections.Generic;
using UnityEngine;
using Vampire.Data;

namespace Vampire.ScriptableObjects
{
    [CreateAssetMenu(fileName = "HeroDataHolder", menuName = "Hero Data Holder")]
    public class HeroHolder: ScriptableObject
    {
       [SerializeField] private HeroData[] _heroData;
       [SerializeField] private string name;

        //public HeroData[] HeroData => _heroData;
    }
}
