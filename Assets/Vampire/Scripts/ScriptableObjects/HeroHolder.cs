using System.Collections.Generic;
using UnityEngine;
using Vampire.Data;

namespace Vampire.ScriptableObjects
{
    [CreateAssetMenu(fileName = "HeroDataHolder", menuName = "Config/Holder/Hero Data Holder")]
    public class HeroHolder: ScriptableObject
    {
       [SerializeField] private HeroData[] _heroData;

        //public HeroData[] HeroData => _heroData;
    }
}
