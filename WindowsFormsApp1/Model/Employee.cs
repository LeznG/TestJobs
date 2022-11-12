using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    /// <summary>
    /// Сотрудник
    /// </summary>
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }

    }
}
