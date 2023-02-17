namespace Vampire.Data
{
    [System.Serializable]
    public struct GradeData<T> 
    {
        public string Name;
        public T[] Detail;
    }
}
