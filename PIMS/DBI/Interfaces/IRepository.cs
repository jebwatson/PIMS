using System;
using System.Collections.Generic;
using System.Text;

namespace DBI.Tables
{
    public interface IRepository<T, TKey>
    {
        void ClearTable();
        void ClearTableById(TKey id);
        TKey CountRows();
        List<T> ReadList();
        List<T> ReadListById(TKey id);
        void UpdateItem(T updatedItem);
        void UpdateList(List<T> updatedList);
        void WriteItem(T newItem);
        void WriteList(List<T> newList);
    }
}
