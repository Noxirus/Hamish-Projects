using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerBillProject // make sure you change this namespace so the new form knows what to reference
{
    //repository of validation methods
    public static class Validator
    {
        public static bool IsPresent(TextBox tb, string name)
        {
            bool valid = true; //"innocent until proven guilty"
            if (tb.Text == "") //incorrect, no input
            {
                valid = false;
                MessageBox.Show(name + " is required", "Input Error"); //cntrl . to pop up a resolution
                tb.Focus();
            }
            return valid;
        }

        public static bool IsInt32(TextBox tb, string name)
        {
            bool valid = true;
            int val;
            if(!Int32.TryParse(tb.Text, out val))
            {
                valid = false;
                MessageBox.Show(name + " needs to be a whole number", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            return valid;
        }
        public static bool IsDouble(TextBox tb, string name)
        {
            bool valid = true;
            double val;
            if (!Double.TryParse(tb.Text, out val))
            {
                valid = false;
                MessageBox.Show(name + " needs to be a number", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            return valid;
        }

        public static bool IsNonNegativeInt32(TextBox tb, string name)
        {
            bool valid = true;
            int val;
            if (!Int32.TryParse(tb.Text, out val))
            {
                valid = false;
                MessageBox.Show(name + " needs to be a whole number", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            else if (val < 0)
            {
                valid = false;
                MessageBox.Show(name + " needs to be a positive number", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
                return valid;
            }
        public static bool IsNonNegativeDouble(TextBox tb, string name)
        {
            bool valid = true;
            double val;
            if (!double.TryParse(tb.Text, out val))
            {
                valid = false;
                MessageBox.Show(name + " needs to be a whole number", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            else if (val < 0)
            {
                valid = false;
                MessageBox.Show(name + " needs to be a positive number", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            return valid;
        }

        public static bool IsDecimal(TextBox tb, string name)
        {
            bool valid = true;
            decimal val;
            if (!Decimal.TryParse(tb.Text, out val))
            {
                valid = false;
                MessageBox.Show(name + " needs to be a number", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            return valid;
        }

        public static bool IsNonNegativeDecimal(TextBox tb, string name)
        {
            bool valid = true;
            decimal val;
            if (!decimal.TryParse(tb.Text, out val))
            {
                valid = false;
                MessageBox.Show(name + " needs to be a decimal number", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            else if (val < 0)
            {
                valid = false;
                MessageBox.Show(name + " needs to be a positive number", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            return valid;
        }

    } // ends class
} // ends namespace
