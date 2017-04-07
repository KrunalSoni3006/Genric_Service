//-----------------------------------------------------------------------
// <copyright file="_DatabaseModel.cs" company="fAsvk">
// Copyright (c) fAsvk TechLab. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Genric_Service
{
    /// <summary>
    /// Main Model Class Which contain all sub Model Class and there object.
    /// </summary>
    public class _DatabaseModel
    {

        /// <summary>
        /// Employee model with Required Property
        /// </summary>
        protected class Employee
        {
            protected string Table_Name = "Emploees";
            /// <summary>
            ///  Gets or sets the Employee Id
            /// </summary>
            public int Id { get; set; }

            /// <summary>
            ///  Gets or sets the Employee Name
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            ///  Gets or sets the Employee gender
            /// </summary>
            public string Gender { get; set; }

            /// <summary>
            /// Gets or sets the salary.
            /// </summary>
            /// <value>
            /// The salary.
            /// </value>
            public int Salary { get; set; }

            /// <summary>
            /// Gets or sets the company identifier.
            /// </summary>
            /// <value>
            /// The company identifier.
            /// </value>
            public int Company_ID { get; set; }
        }

        /// <summary>
        /// Company model with Required Property
        /// </summary>
        
    }

    public class Company
    {
        public Company()
        {
            this.Table_Name = "Companies";
        }
        public string Table_Name { get; private set; }
        /// <summary>
        ///  Gets or sets the Company Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///  Gets or sets the Company Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///  Gets or sets the Company Location
        /// </summary>
        public string Location { get; set; }
    }
}