using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.Enums.Payment
{
    internal enum PaymentStatus
    {
        Pending = 1, //iniciado
        Authorized = 2,
        Completed = 3,
        Failed = 4,
        Canceled = 5,
        Processed = 6 //processado mas sem resposta até o momento
    }
}
