using DI_Commun.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness
{
    public interface IAction<Entity>
    {
        Entity GetById(int id);
        List<Entity> GetAll();
        Entity Add(Entity e);
        bool Update(Entity e);
        bool Delete(Entity e);
    }
}
