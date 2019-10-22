using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Context;
using Database.EntityModels;
namespace Logic.ViewModel
{
    public class RollesView
    {
        public static Dictionary<int, string> GetRoll()
        {
            Dictionary<int, string> RollView = new Dictionary<int, string>();
            var roll = StaticValue.db.Roll;
            foreach(var item in roll)
            {
                RollView.Add(item.Id, item.name);
            }
            return RollView;
        }
        
    }
}
