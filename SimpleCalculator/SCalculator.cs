using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

namespace SimpleCalculator
{
    class SCalculator
    {
        /// <summary>
        /// calculator result of the expression On Science Mode
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="results"></param>
        public void Compute(string expression, out double results)
        {
            results = 0.00;
            object calresult;
            calresult = new DataTable().Compute(expression, null);
            results = Convert.ToDouble(calresult); 
        }

    }
}
