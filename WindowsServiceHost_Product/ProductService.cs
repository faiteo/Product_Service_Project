using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;


namespace WindowsServiceHost_Product
{
    public partial class ProductService : ServiceBase
    {
        ServiceHost host;
        public ProductService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            host = new ServiceHost(typeof(Product_Service_Project.ProductService));
            host.Open();
        }

        protected override void OnStop()
        {
            if (host != null)
            {
                host.Close();
            }
        }
    }
}
