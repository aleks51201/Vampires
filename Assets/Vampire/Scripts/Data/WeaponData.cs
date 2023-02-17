namespace Vampire.Data
{
    [System.Serializable]
    public struct WeaponData
    {
        public string Name;
        public int Damage;
        public float FireRate;
        public BulletData Bullet;
        public ShootingType ShootingType;
        public int[] FiringAngle;
    }
    public enum ShootingType
    {
        forward,
        backward,
        around, 
        custom
    }
}
