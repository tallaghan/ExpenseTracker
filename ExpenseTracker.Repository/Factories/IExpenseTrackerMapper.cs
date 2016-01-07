using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Repository.Factories
{
    public interface IExpenseTrackerMapper
    {

        DTO.IDTOEntity CreateDTOFromEntity(Entities.IEntity entity);

        Entities.IEntity CreateEntityFromDTO(DTO.IDTOEntity entity);

    }
}
