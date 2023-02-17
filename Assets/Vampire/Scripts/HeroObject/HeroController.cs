using UnityEngine;
using Vampire.HeroObject.Simulations;

namespace Vampire.HeroObject
{
    public class HeroController
    {
        private HeroView _heroView;
        private MoveLogic _moveLogic;


        public HeroController(HeroView heroView)
        {
            _heroView = heroView;
        }

        internal void Init()
        {
            _moveLogic = new(_heroView.GetComponent<Rigidbody2D>(), _heroView.transform, 10);
        }

        internal void Update()
        {
        }

        internal void OnEnable()
        {
        }

        internal void OnDisable()
        {
        }
    }
}
