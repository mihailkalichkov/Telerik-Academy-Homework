using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public interface IComment
    {
        void AddComment(string comment);
        void EditComment(string comment);
        string Comments { get; }
    }
}
