using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C4_Class
{
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Text;
        }

        public override bool Equals(object obj)
        {
            if(obj != null && !(obj is System.DBNull))
            {
                return this.Value.Equals(((ComboBoxItem) obj).Value);
            }
            return base.Equals(obj);
        }
    }
}
