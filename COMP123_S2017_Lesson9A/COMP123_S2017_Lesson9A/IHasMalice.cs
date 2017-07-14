using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Harmanpreet Singh
 * Date: July 13, 2017
 * Description: This is an Interface that defines a Malice Property that
 * must be implemented in any class that subscribes to it.
 * Version: 0.1 - Created IHasMalice interface
 */
namespace COMP123_S2017_Lesson9A
{
    /// <summary>
    /// This is the IHasMalice Interface
    /// </summary>
    interface IHasMalice
    {
        int Malice { get; set; }
    }
}
