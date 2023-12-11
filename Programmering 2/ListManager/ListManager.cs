using System.ComponentModel;

namespace ListManager
{
    abstract class ListManager : IListManager<Type>
    {
        List<Type> lista;
        
        public int Count { get { return lista.Count; } }
        public ListManager()
        {
            lista = new List<Type> ();
        }

        public virtual bool Add(Type aType)
        {
            if (aType == null)
            {
                return false;
            }
            else
            {
                lista.Add(aType);
                return true;
            }
        }

        public virtual Type GetAt(int anIndex)
        {
            return lista[anIndex];
        }

        public virtual bool ChangeAt(Type aType, int anIndex)
        {
            if ((anIndex < Count && anIndex > -1) && aType != null)
            {
                lista[anIndex] = aType;
                return true;
            }
            else return false;
        }

        public virtual bool Delete(int anIndex)
        {
            if (anIndex < Count && anIndex > -1)
            {
                lista.RemoveAt(anIndex);
                return true;
            }
            else return false;
        }

        public virtual void DeleteAll()
        {
            lista.Clear();
        }

        public virtual string[] ToStringArray()
        {
            string[] stringArray = new string[Count];
            foreach (Type aType in lista) { stringArray.Append(aType.ToString()); }
            return stringArray;
    }
}