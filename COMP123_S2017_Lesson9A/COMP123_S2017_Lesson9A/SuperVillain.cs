using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Harmanpreet Singh
 * Date: July 13, 2017
 * Description: This is the SuperVillain class which inherits from the SuperHuman class
 * and implements the IHasMalice Interface
 * Version: 0.2 - Modified constructor to take Malice value
 */

namespace COMP123_S2017_Lesson9A
{
    /// <summary>
    /// This is the SuperVillain class
    /// </summary>
    public class SuperVillain : SuperHuman, IHasMalice
    {
        // PRIVATE INSTANCE VARIABLES
        private int _Malice;

        // PUBLIC PROPERTIES
        public int Malice
        {
            get
            {
                return this._Malice;
            }

            set
            {
                this._Malice = value;
            }
        }


        // CONSTRUCTORS

        /// <summary>
        /// This is the main constructor for the SuperVillain class
        /// It takes two argument  - name (string) and malice (int)  
        /// </summary>
        /// <param name="name"></param>
        public SuperVillain(string name,int malice)
            : base(name)
        {
            this.Malice = malice;
        }

        // PRIVATE METHODS

        // PUBLIC METHODS
    }
}