using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    /// <summary>
    /// Должности
    /// </summary>
    internal class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int SubdivisionId { get; set; }
        public Subdivision subdivision { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}
