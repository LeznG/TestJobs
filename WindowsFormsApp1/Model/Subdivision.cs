using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    /// <summary>
    /// Подразделения
    /// </summary>
    internal class Subdivision
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int OrganizationId { get; set; }

        public Organization organization { get; set; }
        public ICollection<Post> Posts { get; set; }


    }
}
