using System;
using UnityEngine;
using Vampire.HeroObject.Simulations;

namespace Vampire.HeroObject
{
    public class HeroController
    {
        private HeroView _heroView;
        private MoveLogic _moveLogic;
        private DamageLogic _damageLogic;


        public HeroController(HeroView heroView)
        {
            _heroView = heroView;
        }

        internal void Init()
        {
            _moveLogic = new(_heroView.GetComponent<Rigidbody2D>(), _heroView.transform, _heroView.MoveSpeed);
            _damageLogic = new();
        }

        internal void Update()
        {
            _moveLogic.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }

        internal void OnTriggerEnter(Collision2D collision)
        {
            Debug.Log("collision enter");
            _heroView.hp=_damageLogic.Damage(_heroView.hp, collision);
            if (_heroView.hp <= 0)
            {
                UnityEngine.Object.Destroy(_heroView.gameObject);
            }
        }

        internal void OnEnable()
        {
        }

        internal void OnDisable()
        {
        }
    }
}
