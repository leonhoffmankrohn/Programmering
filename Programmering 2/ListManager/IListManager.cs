using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListManager
{
    internal interface IListManager<T>
    {
        /// <summary>
        /// Returnerar mängden objekt i listan
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Lägger till ett objekt i listan
        /// </summary>
        /// <param name="aType">ett generiskt objekt</param>
        /// <returns>true om lyckat, false annars</returns>
        bool Add(T aType);

        /// <summary>
        /// Returnerar ett specifikt objekt ur listan
        /// </summary>
        /// <param name="anIndex">objektets index i listan</param>
        /// <returns>ett objekt</returns>
        T GetAt(int anIndex);

        /// <summary>
        /// Ändrar ett specifikt objekt i listan
        /// </summary>
        /// <param name="aType">ett generiskt objekt</param>
        /// <param name="anIndex">dess plats i listan</param>
        /// <returns>true om lyckat, false annars</returns>
        bool ChangeAt(T aType, int anIndex);

        /// <summary>
        /// Tar bort ett specifikt objekt ur listan
        /// </summary>
        /// <param name="anIndex">indexet som ska tas bort</param>
        /// <returns>true om lyckat, false annars</returns>
        bool Delete(int anIndex);

        /// <summary>
        /// Rensar listan
        /// </summary>
        void DeleteAll();

        /// <summary>
        /// Skapar en array med strängar från objektens ToString
        /// </summary>
        /// <returns>en array med strängar</returns>
        string[] ToStringArray();
    }
}

