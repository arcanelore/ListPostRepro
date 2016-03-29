using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simple.OData.Client;
using ListPostRepro.WinForm.Models;

namespace ListPostRepro.WinForm
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private async void buttonRunTest_Click(object sender, EventArgs e)
        {
            ODataClientSettings settings = settings = new ODataClientSettings(textBoxBaseUrl.Text);
            ODataClient client = client = new ODataClient(settings);

            List<ListValueItem> values = new List<ListValueItem>();

            values.Add(new ListValueItem() { ListString = "ListString 1", ListInt = 1 });
            values.Add(new ListValueItem() { ListString = "ListString 2", ListInt = 2 });

            CreateList testList = new CreateList()
            {
                CreateListString = "Create String",
                CreateListInt = 10,
                ListValues = values
            };

            try
            {
                var result = await client
                    .For<CreateList>("CreateListIndex")
                    .Set(testList)
                    .InsertEntryAsync();
            

                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("CreateListString: {0}", result.CreateListString);
                sb.AppendLine();
                sb.AppendFormat("CreateListInt: {0}", result.CreateListInt.ToString());
                foreach (var item in result.ListValues)
                {
                    sb.AppendLine();
                    sb.AppendFormat("ListValues: ListString: {0}, ListInt: {1}", item.ListString, item.ListInt.ToString());
                }

                textBoxResults.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                StringBuilder er = new StringBuilder();
                er.AppendFormat("Error: {0}", ex.Message);
                er.AppendLine();
                if (ex.InnerException != null)
                {
                    er.AppendFormat("Inner Exception: {0}", ex.InnerException.ToString());
                    er.AppendLine();
                }
                er.AppendFormat("Stack Trace: {0}", ex.StackTrace);

                textBoxResults.Text = er.ToString();
            }
        }

        private async void buttonRunListValue_Click(object sender, EventArgs e)
        {
            ODataClientSettings settings = settings = new ODataClientSettings(textBoxBaseUrl.Text);
            ODataClient client = client = new ODataClient(settings);

            List<ListValue> values = new List<ListValue>();

            values.Add(new ListValue() { ListString = "ListString 1", ListInt = 1 });
            values.Add(new ListValue() { ListString = "ListString 2", ListInt = 2 });

            CreateListValue testList = new CreateListValue()
            {
                CreateListString = "Create String",
                CreateListInt = 10,
                ListValues = values
            };

            try
            {
                var result = await client
                    .For<CreateListValue>("CreateListIndexValue")
                    .Set(testList)
                    .InsertEntryAsync();


                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("CreateListString: {0}", result.CreateListString);
                sb.AppendLine();
                sb.AppendFormat("CreateListInt: {0}", result.CreateListInt.ToString());
                foreach (var item in result.ListValues)
                {
                    sb.AppendLine();
                    sb.AppendFormat("ListValues: ListString: {0}, ListInt: {1}", item.ListString, item.ListInt.ToString());
                }

                textBoxResults.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                StringBuilder er = new StringBuilder();
                er.AppendFormat("Error: {0}", ex.Message);
                er.AppendLine();
                if (ex.InnerException != null)
                {
                    er.AppendFormat("Inner Exception: {0}", ex.InnerException.ToString());
                    er.AppendLine();
                }
                er.AppendFormat("Stack Trace: {0}", ex.StackTrace);

                textBoxResults.Text = er.ToString();
            }
        }

        
    }
}
