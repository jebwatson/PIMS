using System;
using System.Collections.Generic;
using System.Text;

namespace DBI.TableInterfaces
{
    interface IBillsTable
    {
        List<Bills> ItemList { get; set; }

        void ReadList();
        void ReadListById(int billId);
        void WriteList();
        void WriteItem(Bills bill);
        void UpdateList();
        void UpdateItem(Bills bill);
        void ClearTable();
        void ClearTableById(int billId);
        int CountRows();
    }
}
