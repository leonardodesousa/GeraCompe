using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;


namespace GeraCompe.Framework
{
    internal class DataSourceEnum
    {
        public void getSource()
        {
            string ProviderName = "Oracle.DataAccess.Client";
            DbProviderFactory factory = DbProviderFactories.GetFactory(ProviderName);

            if (factory.CanCreateDataSourceEnumerator)
            {
                DbDataSourceEnumerator dsenum = factory.CreateDataSourceEnumerator();
                DataTable dt = dsenum.GetDataSources();
                
                System.Windows.Forms.MessageBox.Show(dt.Columns[0] + " : " + dt.Rows[0][0]);
                System.Windows.Forms.MessageBox.Show(dt.Columns[1] + " : " + dt.Rows[0][1]);
                System.Windows.Forms.MessageBox.Show(dt.Columns[2] + " : " + dt.Rows[0][2]);
            }
            else
                System.Windows.Forms.MessageBox.Show("Data source enumeration is not supported by provider");

        }
        
    }
}
