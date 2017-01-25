using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DBI.TableInterfaces
{
    interface IAdmissionsTable
    {
        List<Admission> ItemList { get; set; }

        void ReadList();
        void ReadListById(int admissionId);
        void WriteList();
        void WriteItem(Admission newAdmission);
        void UpdateList();
        void UpdateItem(Admission updatedAdmission);
        void ClearTable();
        void ClearTableById(int admissionId);
        int CountRows();
    }
}
